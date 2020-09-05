using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace quiz_miguel_rueda
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }



        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtmostrar.Visibility = Visibility.Visible;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "Empleado" && txtPassword.Text == "Onlypans123")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.main.NavigationService.Navigate(new Page2());
            }
            else if (txtUsuario.Text == "Admin" && txtPassword.Text == "Admin123")
            {

            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }
    }

    internal class Pagina1
    {
        public Pagina1()
        {
        }
    }
}
