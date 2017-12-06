using GastroCommerce.UserControls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GastroCommerce
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoginLayer.Visibility = Visibility.Visible;
            ContentControl1.Content = new MenuControl();
            ContentControl1.Visibility = Visibility.Collapsed;

            txtName.Text = "Nombre de usuario";
            txtName.GotFocus += new RoutedEventHandler(RemoveText);
            txtName.LostFocus += new RoutedEventHandler(AddTextName);

            txtPassword.Text = "Contrseña";
            txtPassword.LostFocus += new RoutedEventHandler(AddTextPassword);
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "";
            }
        }
        
        public void AddTextName(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Nombre de usuario";
            }
        }

        public void AddTextPassword(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Contraseña";
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginLayer.Visibility = Visibility.Collapsed;
            ContentControl1.Visibility = Visibility.Visible;
        }
    }
}
