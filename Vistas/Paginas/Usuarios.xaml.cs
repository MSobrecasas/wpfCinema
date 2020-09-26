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

namespace Vistas.Paginas
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Page
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
           

          //  MessageBox.Show("Titulo" + oPelicula.Peli_Titulo + "Genero" + oPelicula.Peli_Genero + "Duracion:" + oPelicula.Peli_Duracion + "Clase" + oPelicula.Peli_Clase);
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {


            MessageBox.Show("cancela");
        }
    }
}
