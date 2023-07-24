using ProyectoFinal_23CV.Entities;
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

namespace ProyectoFinal_23CV.Vistas
{
    /// <summary>
    /// Lógica de interacción para VisualizarTicketWindow.xaml
    /// </summary>
    public partial class VisualizarTicketWindow : Window
    {
        public VisualizarTicketWindow()
        {
            InitializeComponent();
        }
        private Venta venta;

        public VisualizarTicketWindow(Venta ventaSeleccionada)
        {
            InitializeComponent();
            venta = ventaSeleccionada;

            // Mostrar la información de la venta en los controles adecuados
            MostrarInformacionVenta();
        }

        private void MostrarInformacionVenta()
        {
            if (venta != null)
            {
                // Mostrar la información de la venta en los controles de la ventana
                TxtInfoTicket.Text = $"Venta ID: {venta.PkVenta}\n" +

                                     $"Vendedor: {venta.Vendedor.Nombre}\n" +

                                     $"Producto: {venta.NombreProducto}\n" +

                                     $"Cantidad: {venta.Cantidad}\n" +

                                     $"Fecha: {venta.FechaVenta}\n" +

                                     $"Subtotal: {venta.Subtotal}\n" +

                                     $"IVA: {venta.Iva}\n" +

                                     $"Total: {venta.Total}";
            }
        }
    }
}
