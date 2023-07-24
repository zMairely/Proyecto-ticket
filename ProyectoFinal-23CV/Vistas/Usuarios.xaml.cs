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

namespace ProyectoFinal_23CV.Vistas
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Window
    {
        public Usuarios()
        {
            InitializeComponent();
            GetUserTable();
            GetRoles();
        }
        UsuarioServices services = new UsuarioServices();

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            Usuario usuario = new Usuario();



            if (txtPkUser.Text == "")
            {


                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Faltan campos");
                }
                else
                {

                    usuario.Nombre = txtNombre.Text;
                    usuario.UserName = txtUsername.Text;
                    usuario.Password = txtPassword.Text;
                    usuario.FkRol = int.Parse(SelectRol.SelectedValue.ToString());
                    txtNombre.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("Se agrego correctamente");
                    services.AddUser(usuario);
                    GetUserTable();
                }


            }
            else
            {
                int userId = int.Parse(txtPkUser.Text);
                usuario.Nombre = txtNombre.Text;
                usuario.UserName = txtUsername.Text;
                usuario.Password = txtPassword.Text;
                usuario.FkRol = int.Parse(SelectRol.SelectedValue.ToString());

                services.UpdateUser(userId, usuario);

                txtPkUser.Clear();
                txtNombre.Clear();
                txtUsername.Clear();
                txtPassword.Clear();

                MessageBox.Show("Se actualizó correctamente");
                GetUserTable();
            }




        }
        private void DeleteItem(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Usuario usuario)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    services.DeleteUser(usuario.PkUsuario);
                    GetUserTable();
                }
            }
        }

        public void GetUserTable()
        {
            UserTable.ItemsSource = services.GetUsers();

        }

        public void GetRoles()
        {
            SelectRol.ItemsSource = services.GetRoles();
            SelectRol.DisplayMemberPath = "Nombre";
            SelectRol.SelectedValuePath = "PkRol";
        }


        public void EditItem(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario = (sender as FrameworkElement).DataContext as Usuario; //Esta funcion traera la selecion de la fila 

            txtPkUser.Text = usuario.PkUsuario.ToString();
            txtNombre.Text = usuario.Nombre.ToString();
            txtUsername.Text = usuario.UserName.ToString();
            txtPassword.Text = usuario.Password.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
