using ProyectoFinal_23CV.Entities;
using ProyectoFinal_23CV.Services;
using ProyectoFinal_23CV.Vistas_Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoFinal_23CV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Productos prod=new Productos();
        public MainWindow()
        {
            InitializeComponent();
            
        }





        private Usuario UsuarioActual;



        UsuarioServices services = new UsuarioServices();
        private void Iniciar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string user = txtUserName.Text;
            string password = txtPassword.Password;
            

            var response = services.Login(user, password);

            if (response.Roles.Nombre == "Admin")
            {
                UsuarioActual = response;
                SGBD ventanaSGBD = new SGBD(UsuarioActual);
             
                ventanaSGBD.Show();
               
                Close();


            }
            else
            {
                UsuarioActual = response;
                EmpleadoVista empleador = new EmpleadoVista(UsuarioActual);
                empleador.Show();
                Close();
                //UsuarioActual = response;
                //Ventas venta = new Ventas(UsuarioActual);
               
                //Close();
                //venta.Show();   
            }

        }
    }
}
