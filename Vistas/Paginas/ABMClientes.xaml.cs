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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas.Paginas {
    /// <summary>
    /// Interaction logic for Clientes.xaml
    /// </summary>
    public partial class ABMClientes : Window {
        public ABMClientes() {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e) {
            Cliente oCliente = new Cliente();
            oCliente.Cli_Nombre = txtNombre.Dato;
            oCliente.Cli_Apellido = txtApellido.Dato;
            oCliente.Cli_DNI = Convert.ToInt32(txtDNI.Dato);
            oCliente.Cli_Email = txtEmail.Dato;
            oCliente.Cli_Telefono = txtTelefono.Dato;

            MessageBox.Show("Nombre: "+oCliente.Cli_Nombre+"Apellido: "+
                oCliente.Cli_Apellido+ "DNI: " + oCliente.Cli_DNI + "E-mail: " + 
                oCliente.Cli_Email + "Telefono: " + oCliente.Cli_Telefono);
            
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
