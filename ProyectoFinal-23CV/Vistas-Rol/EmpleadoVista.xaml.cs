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

namespace ProyectoFinal_23CV.Vistas_Wpf
{
    /// <summary>
    /// Lógica de interacción para EmpleadoVista.xaml
    /// </summary>
    public partial class EmpleadoVista : Window
    {
        public event EventHandler OpenProductosButtonClicked;

        public Usuario UsuarioActual;
        public EmpleadoVista(Usuario usuarioActual) // Corrección en la firma del constructor
        {
            InitializeComponent();
            UsuarioActual = usuarioActual;
        }

        private void btnverproductos_Click(object sender, RoutedEventArgs e)
        {
            Productos ver = new Productos();
            ver.Show();
            

            

            
        }

        private void btnvender_Click(object sender, RoutedEventArgs e)
        {
            Ventas ver = new Ventas(UsuarioActual);
            ver.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
