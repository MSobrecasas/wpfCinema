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

namespace Vistas.Paginas
{
    /// <summary>
    /// Lógica de interacción para ABMProyecciones.xaml
    /// </summary>
    public partial class ABMProyecciones : Window
    {
        public ABMProyecciones()
        {
            InitializeComponent();
        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {

        }
        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
