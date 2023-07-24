using ProyectoFinal_23CV.Entities;
using ProyectoFinal_23CV.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ProyectoFinal_23CV.Vistas_Wpf
{
    public partial class Productos : Window
    {
        private ProductoServices productoServices = new ProductoServices();



    



        public Productos()
        {
            InitializeComponent();

          
            


            GetProductosTable();
        }

        public void BotonVisible(string userType)
        {

            GuardarProductoBTN.IsEnabled = false;
            txtProductoNombre.IsEnabled = false;
            txtProductoPrecio.IsEnabled = false;
            precioproductolabel.IsEnabled = false;
            nombreproductolabel.IsEnabled = false;

        }







        private void GuardarProductoBTN_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto();

            if (string.IsNullOrEmpty(txtPkProducto.Text))
            {
                if (string.IsNullOrEmpty(txtProductoNombre.Text) || string.IsNullOrEmpty(txtProductoPrecio.Text))
                {
                    MessageBox.Show("Faltan campos");
                }
                else
                {
                    producto.NombreProducto = txtProductoNombre.Text;
                    producto.PrecioProducto = Convert.ToInt32(txtProductoPrecio.Text);

                    productoServices.AddProducto(producto);
                    GetProductosTable();

                    txtProductoNombre.Clear();
                    txtProductoPrecio.Clear();
                }
            }
            else
            {
                int productId = Convert.ToInt32(txtPkProducto.Text);
                producto.PkProducto = productId; // Asegúrate de establecer el ID del producto

                producto.NombreProducto = txtProductoNombre.Text; // Actualiza el nombre del producto
                producto.PrecioProducto = Convert.ToInt32(txtProductoPrecio.Text); // Actualiza el precio del producto

                productoServices.UpdateProducto(productId, producto);
                GetProductosTable();

                txtPkProducto.Clear();
                txtProductoNombre.Clear();
                txtProductoPrecio.Clear();
            }
        }

        private void DeleteItemProducto(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Producto producto)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    productoServices.DeleteProducto(producto.PkProducto);
                    GetProductosTable();
                }
            }
        }

        private void EditItemProducto(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Producto producto)
            {
                txtPkProducto.Text = producto.PkProducto.ToString();
                txtProductoNombre.Text = producto.NombreProducto;
                txtProductoPrecio.Text = producto.PrecioProducto.ToString();
                GetProductosTable();
            }
        }



        







        private void GetProductosTable()
        {
            UserTable.ItemsSource = productoServices.GetProductos();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
