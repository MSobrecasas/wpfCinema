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
using Vistas.Paginas;

namespace Vistas {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

            Uri uPelicula = new System.Uri("Paginas/Peliculas.xaml", UriKind.RelativeOrAbsolute);
            Uri uCliente = new System.Uri("Paginas/Clientes.xaml", UriKind.RelativeOrAbsolute);
            Uri uUsuario = new System.Uri("Paginas/Usuarios.xaml", UriKind.RelativeOrAbsolute);
            Uri uGrilla = new System.Uri("Paginas/DataGridBasica.xaml", UriKind.RelativeOrAbsolute);
            Uri uVentaTicket = new System.Uri("Paginas/VentaButacas.xaml", UriKind.RelativeOrAbsolute);
            Uri uProyecciones = new System.Uri("Paginas/Proyecciones.xaml", UriKind.RelativeOrAbsolute);
        public MainWindow(int user) {
            InitializeComponent();
            

            if (user == 1) {
                btnPelicula.Visibility = Visibility.Visible;
                btnUsuarios.Visibility = Visibility.Visible;
                btnButacas.Visibility = Visibility.Visible;
                btnProyecciones.Visibility = Visibility.Visible;
                btnClientes.Visibility = Visibility.Collapsed;
                btnTickets.Visibility = Visibility.Collapsed;
            }
            else {
                btnPelicula.Visibility = Visibility.Collapsed;
                btnUsuarios.Visibility = Visibility.Collapsed;
                btnButacas.Visibility = Visibility.Collapsed;
                btnProyecciones.Visibility = Visibility.Collapsed;
                btnClientes.Visibility = Visibility.Visible;
                btnTickets.Visibility = Visibility.Visible;
            }
            Imagenes();

        }

        private void btnPelicula_Click(object sender, RoutedEventArgs e) {


            FrameMain.Source = uPelicula;
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e) {
            FrameMain.Source = uCliente;
        }

      private void Imagenes(){
      
    }

      private void btnTickets_Click(object sender, RoutedEventArgs e) {
            FrameMain.Source = uVentaTicket;
      }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Source = uGrilla;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnProyecciones_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Source = uProyecciones;
        }
    }
}
