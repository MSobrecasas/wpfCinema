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
using System.Data;
using ClasesBase;
using ClasesBase.ListasAuxiliares;
namespace Vistas.Paginas
{
    /// <summary>
    /// Lógica de interacción para DataGridBasica.xaml
    /// </summary>
    public partial class DataGridBasica : Page
    {
        string titulo ="";
        Uri uPelicula = new System.Uri("Paginas/Peliculas.xaml", UriKind.RelativeOrAbsolute);
        Uri uCliente = new System.Uri("Paginas/Clientes.xaml", UriKind.RelativeOrAbsolute);
        Uri uUsuario = new System.Uri("Paginas/Usuarios.xaml", UriKind.RelativeOrAbsolute);
        Uri uGrilla = new System.Uri("Paginas/DataGridBasica.xaml", UriKind.RelativeOrAbsolute);
        Uri uVentaTicket = new System.Uri("Paginas/VentaButacas.xaml", UriKind.RelativeOrAbsolute);

        string tipo = string.Empty;
      
    public DataGridBasica()
        {

            InitializeComponent();
            clientes();
        }

        
                
        
        private void clientes()
        {
            Lista.ItemsSource = null;
            ListaCliente CL = new ListaCliente();
            Lista.ItemsSource = CL.cargar_lista();

            GridViewColumn column = new GridViewColumn();
             column.Header = "Nombre";
             column.Width = 140;
             column.DisplayMemberBinding = new Binding("Cli_Nombre");
             GV.Columns.Add(column);

             GridViewColumn column1 = new GridViewColumn();
             column1.Header = "Apellido";
             column1.Width = 140;
             column1.DisplayMemberBinding = new Binding("Cli_Apellido");
             GV.Columns.Add(column1);

            GridViewColumn column2 = new GridViewColumn();
            column2.Header = "DNI";
            column2.Width = 140;
            column2.DisplayMemberBinding = new Binding("Cli_DNI");
            GV.Columns.Add(column2);

            GridViewColumn column3 = new GridViewColumn();
            column3.Header = "Telefono";
            column3.Width = 140;
            column3.DisplayMemberBinding = new Binding("Cli_Telefono");
            GV.Columns.Add(column3);

            GridViewColumn column4 = new GridViewColumn();
            column4.Header = "E-mail";
            column4.Width = 140;
            column4.DisplayMemberBinding = new Binding("Cli_Email");
            GV.Columns.Add(column4);

          

        }

   

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ABMClientes oClientes = new ABMClientes();
            oClientes.ShowDialog() ;
          
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
