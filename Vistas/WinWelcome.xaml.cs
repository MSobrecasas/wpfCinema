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
using ClasesBase.Enlaces;
using System.Data;


namespace Vistas {
    /// <summary>
    /// Interaction logic for WinWelcome.xaml
    /// </summary>
    public partial class WinWelcome : Window {
        public WinWelcome() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) {
            string user = login.Usuario;
            string pass = login.Contrseña;
            int usert = 0;
            int rol = 0;
            rol = validar(user, pass);
             if ( rol != 0) {
                 if  (rol == 1 ) {
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

        public int validar(string user, string pass)
        {

            DataTable dt = ABMUsuario.obtener_rol(user,pass);

            if (dt.Rows.Count == 1)
            {

                if (dt.Rows[0][0].ToString() == "1")
                {
                    return 1;
                }
                else
                {
                    if (dt.Rows[0][0].ToString() == "2")
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }

                }
            }
            else
            {
                return 0;
            }


        }
    }
}
