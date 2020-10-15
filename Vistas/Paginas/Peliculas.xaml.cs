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
using ClasesBase.Enlaces;
using System.Data;

namespace Vistas.Paginas
{
    /// <summary>
    /// Lógica de interacción para Peliculas.xaml
    /// </summary>
    public partial class Peliculas : Page
    {
        Pelicula oPelicula = new Pelicula();
        public Peliculas()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ABMPeliculas oPel = new ABMPeliculas("Nueva Pelicula");
            oPel.ShowDialog();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            ABMPeliculas oPel = new ABMPeliculas("Modificar Pelicula");
            oPel.txtID.Text = oPelicula.Peli_ID.ToString();
            oPel.txtTitulo.txt.Text = oPelicula.Peli_Titulo;
            oPel.txtDuracion.txt.Text = oPelicula.Peli_Duracion;
            oPel.cmbGenero.SelectedValue = oPelicula.Gen_ID;
            oPel.cmbClase.SelectedValue = oPelicula.Cla_ID;
            oPel.ShowDialog();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            ABMPelicula.eliminar_pelicula(oPelicula);
        }

        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ( Lista.SelectedItem != null)
            {
               
                DataRowView rowView = Lista.SelectedItem as DataRowView;
                MessageBox.Show(string.Format(rowView["peli_ID"].ToString()));
                oPelicula.Peli_ID = Convert.ToInt32(string.Format(rowView["peli_ID"].ToString()));
                oPelicula.Peli_Titulo = string.Format(rowView["peli_Titulo"].ToString());
                oPelicula.Peli_Duracion = string.Format(rowView["peli_Duracion"].ToString());
                oPelicula.Cla_ID = Convert.ToInt32(string.Format(rowView["cla_ID"].ToString()));
                oPelicula.Gen_ID = Convert.ToInt32(string.Format(rowView["gen_ID"].ToString()));

            }
        }


      
    }
}
