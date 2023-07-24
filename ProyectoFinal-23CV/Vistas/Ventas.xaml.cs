using ProyectoFinal_23CV.Context;
using ProyectoFinal_23CV.Entities;
using ProyectoFinal_23CV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Printing;
using ProyectoFinal_23CV.Vistas;

namespace ProyectoFinal_23CV.Vistas_Wpf
{
    /// <summary>
    /// Lógica de interacción para Ventas.xaml
    /// </summary>
    public partial class Ventas : Window
    {
        private readonly VentaServices services = new VentaServices();
        public Ventas(Usuario usuarioActual)
        {
            InitializeComponent();
            UsuarioActual = usuarioActual;
            Funcion();
        }

        public Usuario UsuarioActual;
        private Producto productoSeleccionado;

        private void Funcion()
        {
            List<Venta> ventas = this.services.GetVentas();

            // Recorrer cada venta para obtener el nombre y precio del producto y calcular subtotal, IVA y total.
            foreach (var venta in ventas)
            {
                Producto producto = ObtenerProducto(venta.FkProducto);
                venta.NombreProducto = producto?.NombreProducto;

                // Asignar el precio directamente si Producto no es nulo
                venta.PrecioProducto = producto?.PrecioProducto ?? 0.0;

                // Calcular el subtotal, IVA y total
                venta.Subtotal = venta.PrecioProducto * venta.Cantidad;
                venta.Iva = venta.Subtotal * 0.16;
                venta.Total = venta.Subtotal + venta.Iva;
                venta.Vendedor = ObtenerVendedor(venta.FkVendedor);
            }

            GridVentas.ItemsSource = ventas;
        }
        private Usuario ObtenerVendedor(int? codigoVendedor)
        {
            if (codigoVendedor.HasValue)
            {
                using (var _context = new ApplicationDbContext())
                {
                    Usuario vendedor = _context.Usuarios.FirstOrDefault(u => u.PkUsuario == codigoVendedor.Value);
                    return vendedor;
                }
            }

            return null;
        }


        private Producto ObtenerProducto(int? codigoProducto)
        {
            if (codigoProducto.HasValue)
            {
                using (var _context = new ApplicationDbContext())
                {
                    Producto producto = _context.Productos.FirstOrDefault(p => p.PkProducto == codigoProducto.Value);
                    return producto;
                }
            }

            return null;
        }

        private void BTGuardar(object sender, RoutedEventArgs e)
        {
            // Validar que se haya seleccionado un producto
            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto válido.");
                return;
            }

            // Validar que se haya ingresado una cantidad válida
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            // Obtener el producto seleccionado del ComboBox
            Producto productoSeleccionado = cmbProductos.SelectedItem as Producto;

            // Calcular subtotal, IVA y total
            double subtotal = productoSeleccionado.PrecioProducto * cantidad;
            double iva = subtotal * 0.16;
            double total = subtotal + iva;


            if (int.TryParse(txtIDVenta.Text, out int idVenta))
            {
                // Si el ID de venta es válido, significa que estamos editando una venta existente
                using (var _context = new ApplicationDbContext())
                {
                    Venta ventaExistente = _context.Ventas.FirstOrDefault(v => v.PkVenta == idVenta);
                    if (ventaExistente != null)
                    {
                        // Actualizar los datos de la venta existente
                        ventaExistente.FkProducto = productoSeleccionado.PkProducto;
                        ventaExistente.Cantidad = cantidad;
                        ventaExistente.Subtotal = subtotal;
                        ventaExistente.Iva = iva;
                        ventaExistente.Total = total;
                        ventaExistente.Vendedor = UsuarioActual;
                    }
                    else
                    {
                        MessageBox.Show("La venta seleccionada no existe.");
                        return;
                    }

                    _context.SaveChanges();
                    MessageBox.Show("Se actualizó correctamente");
                }
            }
            else
            {
                // Si el ID de venta no es válido, significa que estamos creando una nueva venta
                using (var _context = new ApplicationDbContext())
                {
                    MessageBox.Show("Valor de UsuarioActual.PkUsuario: " + UsuarioActual.PkUsuario);
                    Venta nuevaVenta = new Venta
                    {
                        FkProducto = productoSeleccionado.PkProducto,
                        FechaVenta = DateTime.Now,
                        Cantidad = cantidad,
                        Subtotal = subtotal,
                        Iva = iva,
                        Total = total,
                        FkVendedor = UsuarioActual.PkUsuario,
                    };

                    _context.Ventas.Add(nuevaVenta);
                    _context.SaveChanges();
                    MessageBox.Show("Se agregó correctamente");
                }
            }

            // Limpiar los campos para una nueva venta
            LimpiarCampos();

            // Actualizar la lista de ventas en el DataGrid
            Funcion();
        }

        private void LimpiarCampos()
        {
            cmbProductos.SelectedItem = null;
            txtCantidad.Text = "";
            txtSubtotal.Text = "";
            txtIva.Text = "";
            txtTotal.Text = "";
        }

        public void EditItemVentas()
        {
            if (GridVentas.SelectedItem is Venta venta)
            {
                // Rellenar los campos con los datos de la venta seleccionada
                txtIDVenta.Text = venta.PkVenta.ToString();
                cmbProductos.SelectedItem = venta.Producto;
                txtCantidad.Text = venta.Cantidad.ToString();
                txtPrecio.Text = venta.PrecioProducto.ToString();

                // Calcular y mostrar los valores de subtotal, IVA y total
                CalcularValores();
            }
        }

        public void DeleteItemVentas()
        {
            if (GridVentas.SelectedItem is Venta venta)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta venta?", "Confirmar eliminación", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    // Eliminar la venta de la base de datos
                    services.DeleteVenta(venta.PkVenta);

                    // Actualizar el DataGrid para reflejar los cambios
                    Funcion();
                }
            }
        }

        private void cmbProductos_Loaded(object sender, RoutedEventArgs e)
        {
            // Cargar la lista de productos en el ComboBox
            cmbProductos.ItemsSource = ObtenerProductos();
        }

        private List<Producto> ObtenerProductos()
        {
            using (var _context = new ApplicationDbContext())
            {
                return _context.Productos.ToList();
            }
        }



        private void CmbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productoSeleccionado = cmbProductos.SelectedItem as Producto;
            if (productoSeleccionado != null)
            {
                // Rellenar los TextBox con los valores del producto seleccionado
                txtSubtotal.Text = (productoSeleccionado.PrecioProducto * int.Parse(txtCantidad.Text)).ToString();
                txtIva.Text = (productoSeleccionado.PrecioProducto * int.Parse(txtCantidad.Text) * 0.16).ToString();
                txtTotal.Text = (productoSeleccionado.PrecioProducto * int.Parse(txtCantidad.Text) * 1.16).ToString();
            }
        }

        private void TxtCantidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (productoSeleccionado != null && int.TryParse(txtCantidad.Text, out int cantidad))
            {
                // Actualizar los TextBox cuando se cambie la cantidad
                txtSubtotal.Text = (productoSeleccionado.PrecioProducto * cantidad).ToString();
                txtIva.Text = (productoSeleccionado.PrecioProducto * cantidad * 0.16).ToString();
                txtTotal.Text = (productoSeleccionado.PrecioProducto * cantidad * 1.16).ToString();
            }
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            EditItemVentas();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            DeleteItemVentas();
        }

        private void CalcularValores()
        {
            if (productoSeleccionado != null && int.TryParse(txtCantidad.Text, out int cantidad) && double.TryParse(txtPrecio.Text, out double precio))
            {
                // Calcular los valores de subtotal, IVA y total
                double subtotal = precio * cantidad;
                double iva = subtotal * 0.16;
                double total = subtotal + iva;

                // Actualizar los TextBox con los valores calculados
                txtSubtotal.Text = subtotal.ToString();
                txtIva.Text = iva.ToString();
                txtTotal.Text = total.ToString();
            }
        }

        private void txtCantidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Lógica para actualizar los campos de subtotal, IVA y total al cambiar la cantidad
            CalcularValores();
        }

        private void txtPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Lógica para actualizar los campos de subtotal, IVA y total al cambiar el precio
            CalcularValores();
        }

        private void cmbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productoSeleccionado = cmbProductos.SelectedItem as Producto;
            if (productoSeleccionado != null)
            {
                // Lógica para actualizar el TextBox de precio y los campos de subtotal, IVA y total al seleccionar un producto
                txtPrecio.Text = productoSeleccionado.PrecioProducto.ToString();
                CalcularValores();
            }
        }
        private void BTImprimirTicket_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si hay una venta seleccionada en el DataGrid
            if (GridVentas.SelectedItem is Venta ventaSeleccionada)
            {
                // Crear la ventana de VisualizarTicketWindow y pasar la venta seleccionada
                VisualizarTicketWindow visualizarTicketWindow = new VisualizarTicketWindow(ventaSeleccionada);
                visualizarTicketWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una venta para imprimir el ticket.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}