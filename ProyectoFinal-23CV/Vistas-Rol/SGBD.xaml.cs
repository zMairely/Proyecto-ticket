using ProyectoFinal_23CV.Entities;
using ProyectoFinal_23CV.Services;
using ProyectoFinal_23CV.Vistas;
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
    /// Lógica de interacción para SGBD.xaml
    /// </summary>
    public partial class SGBD : Window
    {
        public Usuario UsuarioActual;

        public SGBD(Usuario usuarioActual)
        {
            InitializeComponent();
            UsuarioActual = usuarioActual;
        }

        private void btnaggUsuario_Click(object sender, RoutedEventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void btnaggPoducto_Click(object sender, RoutedEventArgs e)
        {
            Productos producter = new Productos();  
            producter.Show();
        }

        private void btnVentasAdmin_Click(object sender, RoutedEventArgs e)
        {
            Ventas ventas = new Ventas(UsuarioActual);
            ventas.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main= new MainWindow();  
            main.Show();

        }
    }
}
