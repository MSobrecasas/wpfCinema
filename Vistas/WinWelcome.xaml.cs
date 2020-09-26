using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;
namespace Vistas {
    /// <summary>
    /// Interaction logic for WinWelcome.xaml
    /// </summary>
    public partial class WinWelcome : Window {
        public WinWelcome() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) {
            Usuario oUser = new Usuario();
            string user = login.Usuario;
            string pass = login.Contrseña;
            int usert = 0;
             if ( (user == "Admin" && pass == "admin")
                 || (user == "Vendedor" && pass == "vend")) {
                 if  (user == "Admin" ) {
                 usert = 1;
                 }
                     MainWindow oMain = new MainWindow(usert);
                     oMain.Show();
                this.Hide();

             }
             else {
                 MessageBox.Show("Datos Incorrectos");
             }
        }

        private void btn_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
