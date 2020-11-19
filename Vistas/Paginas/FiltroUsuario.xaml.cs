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
using Vistas.FlowDocs;

using ClasesBase;

namespace Vistas.Paginas
{
    /// <summary>
    /// Lógica de interacción para FiltroUsuario.xaml
    /// </summary>
    public partial class FiltroUsuario : Window
    {
        private CollectionViewSource vistaColeccionFiltrada;
        public FiltroUsuario()
        {
            InitializeComponent();

            vistaColeccionFiltrada = Resources["vista_user"] as CollectionViewSource;
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (vistaColeccionFiltrada != null)
            {
                vistaColeccionFiltrada.Filter += eventVistaUsuario_Filter;
            }
        }

        private void eventVistaUsuario_Filter(object sender, FilterEventArgs e)
        {
            Usuario usuario = e.Item as Usuario;

            if (usuario.Usu_NombreUsuario.StartsWith(txtBuscar.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }
        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            FlowDocUsuario imp = new FlowDocUsuario();
            imp.Show();
        }
    }
}
