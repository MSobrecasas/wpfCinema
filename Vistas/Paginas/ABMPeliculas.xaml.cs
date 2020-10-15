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

namespace Vistas.Paginas {
    /// <summary>
    /// Interaction logic for Peliculas.xaml
    /// </summary>
    public partial class ABMPeliculas : Window {

        public ABMPeliculas(string titulo) {
            InitializeComponent();
            
            Titulo.Text = titulo;
            
        }
      

        private void Guardar_Click(object sender, RoutedEventArgs e) {
            if (Titulo.Text =="Nueva Pelicula")
            {
                nueva_pelicula();
            }
            else
            {
                modificar_pelicula();
            }
            
        }
        private void nueva_pelicula()
        {
            Pelicula oPelicula = new Pelicula();
            
            oPelicula.Peli_Titulo = txtTitulo.Dato;
            oPelicula.Peli_Duracion = txtDuracion.Dato;
            oPelicula.Cla_ID = Convert.ToInt32(cmbClase.SelectedValue.ToString());
            oPelicula.Gen_ID = Convert.ToInt32(cmbGenero.SelectedValue.ToString());

            ABMPelicula.nueva_pelicula(oPelicula);

            MessageBox.Show("Titulo"+oPelicula.Peli_Titulo+"Genero"+oPelicula.Gen_ID+"Duracion:"+oPelicula.Peli_Duracion+"Clase"+ oPelicula.Cla_ID);
        }
        private void modificar_pelicula()
        {
            Pelicula oPelicula = new Pelicula();
            oPelicula.Peli_ID = Convert.ToInt32(txtID.Text.ToString());
            oPelicula.Peli_Titulo = txtTitulo.Dato;
            oPelicula.Peli_Duracion = txtDuracion.Dato;
            oPelicula.Cla_ID = Convert.ToInt32(cmbClase.SelectedValue.ToString());
            oPelicula.Gen_ID = Convert.ToInt32(cmbGenero.SelectedValue.ToString());

            ABMPelicula.modificar_pelicula(oPelicula);

            MessageBox.Show("Titulo" + oPelicula.Peli_Titulo + "Genero" + oPelicula.Gen_ID + "Duracion:" + oPelicula.Peli_Duracion + "Clase" + oPelicula.Cla_ID);
        }

        private void cargar_Combo()
        {
            cmbGenero.DisplayMemberPath = "gen_Nombre";
            cmbGenero.SelectedValuePath = "gen_ID";
            cmbGenero.ItemsSource = ABMGenero.list_Genero().DefaultView;

            cmbClase.DisplayMemberPath = "cla_Nombre";
            cmbClase.SelectedValuePath = "cla_ID";
            cmbClase.ItemsSource = ABMClase.list_Clase().DefaultView;

        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            cargar_Combo();
        }
    }
}
