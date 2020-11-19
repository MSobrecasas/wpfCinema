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
using System.Collections.ObjectModel;
using ClasesBase;
using ClasesBase.Enlaces;
namespace Vistas.Paginas
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Page
    {
        bool nuevo = true;
        string _usuario ="";
        public Usuarios()
        {
            InitializeComponent();
        }
        CollectionView Vista;
        ObservableCollection<Usuario> listaUsuario;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cargar_Combo();
            llenar_vista();

        }
        private void add_Click(object sender, RoutedEventArgs e)
        {        
            habilitar_tetxbox();
            nuevo = true;
            habilitar_botones();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        { 
            nuevo = false;
            txtuser.Text = tbxuser.Text;
            txtpass.Text = tbxpass.Text;
            txtnya.Text = tbxnya.Text;
            cmbRol.SelectedValue = tbxrol.Text;
            habilitar_tetxbox();
            habilitar_botones();
            _usuario = txtuser.Text;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            
            if (MessageBox.Show("Desea eliminar el Usuario?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                
            }
            else
            {
                Usuario oUser = new Usuario();
                oUser.Usu_ID = Convert.ToInt32(tbxID.Text);
                ABMUsuario.eliminar_usuario(oUser);
                MessageBox.Show("Usuario Eliminado");
                this.NavigationService.Refresh();

            }
        }

        private void btn_first_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToFirst();
        }

        private void btn_previous_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToPrevious();
            if (Vista.IsCurrentBeforeFirst)
            {
                Vista.MoveCurrentToLast();
            }
        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToNext();
            if (Vista.IsCurrentAfterLast)
            {
                Vista.MoveCurrentToFirst();
            }
        }

        private void btn_last_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToLast();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            deshabilitar_botones();
            deshabilitar_textbox();
            limpiar_campos();
        }
        
        private void Guardar_Click()
        {
            
            if (ABMUsuario.usuario_existente(txtuser.Text) == 0 && nuevo == true)
            {
                nuevo_usuario();
                this.NavigationService.Refresh();
                limpiar_campos();
            }else
            {
                if (nuevo == false &&
                    (ABMUsuario.usuario_existente(txtuser.Text) == 0 || _usuario == txtuser.Text))
                {
                    modificar_usuario();
                    this.NavigationService.Refresh();
                    limpiar_campos();
                }else
                {
                    MessageBox.Show("Nombre de usuario Existente");
                }
                
            }
         
        }
        private void cargar_Combo()
        {
            cmbRol.DisplayMemberPath = "rol_Descripcion";
            cmbRol.SelectedValuePath = "rol_Codigo";
            cmbRol.ItemsSource = ABMRol.cargar_rol().DefaultView;
        }

        private void nuevo_usuario()
        {
            Usuario oUser = new Usuario();

            oUser.Usu_NombreUsuario = txtuser.Text;
            oUser.Usu_Contraseña = txtpass.Text;
            oUser.Usu_ApellidoNombre = txtnya.Text;
            oUser.Rol_Codigo = Convert.ToInt32(cmbRol.SelectedValue.ToString());
            ABMUsuario.nuevo_usuario(oUser);
            listaUsuario.Add(oUser);
            Vista.MoveCurrentToLast();
            deshabilitar_textbox();
        }
        private void modificar_usuario()
        {
            
            Usuario oUser = new Usuario();
            oUser.Usu_ID = Convert.ToInt32(tbxID.Text);
            oUser.Usu_NombreUsuario = txtuser.Text;
            oUser.Usu_Contraseña = txtpass.Text;
            oUser.Usu_ApellidoNombre = txtnya.Text;
            oUser.Rol_Codigo = Convert.ToInt32(cmbRol.SelectedValue.ToString());
            ABMUsuario.modificar_usuario(oUser);
                        
            Vista.MoveCurrentToLast();
            Vista.MoveCurrentToPosition(0);
            deshabilitar_textbox();
        }

        private void llenar_vista()
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["list_Usuario"];
            listaUsuario = odp.Data as ObservableCollection<Usuario>;
            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_usuario.DataContext);
        }

        private void habilitar_botones()
        {
            Guardar.Visibility = Visibility.Visible;
            Cancelar.Visibility = Visibility.Visible;
            Grid_AED.Visibility = Visibility.Collapsed;
            Grid_panel.Visibility = Visibility.Hidden;
        }
        private void deshabilitar_botones()
        {
            Guardar.Visibility = Visibility.Hidden;
            Cancelar.Visibility = Visibility.Hidden;
            Grid_AED.Visibility = Visibility.Visible;
            Grid_panel.Visibility = Visibility.Visible;
        }

        private void deshabilitar_textbox()
        {
            txtuser.Visibility = Visibility.Hidden;
            txtpass.Visibility = Visibility.Hidden;
            txtnya.Visibility = Visibility.Hidden;
            gridcmb.Visibility = Visibility.Hidden;

            tbxuser.Visibility = Visibility.Visible;
            tbxpass.Visibility = Visibility.Visible;
            tbxnya.Visibility = Visibility.Visible;
            tbxrol.Visibility = Visibility.Visible;
        }

        private void habilitar_tetxbox()
        {
            txtuser.Visibility = Visibility.Visible;
            txtpass.Visibility = Visibility.Visible;
            txtnya.Visibility = Visibility.Visible;
            gridcmb.Visibility = Visibility.Visible;

            tbxuser.Visibility = Visibility.Hidden;
            tbxpass.Visibility = Visibility.Hidden;
            tbxnya.Visibility = Visibility.Hidden;
            tbxrol.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FiltroUsuario oFiltro = new FiltroUsuario();
            oFiltro.ShowDialog();
        }

        private int _noOfErrorsOnScreen = 0;
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                _noOfErrorsOnScreen++;
            else
                _noOfErrorsOnScreen--;
        }

        private void AddUser_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _noOfErrorsOnScreen == 0;
            e.Handled = true;
        }

        private void AddUser_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Guardar_Click();
            e.Handled = true;

        }

        private void limpiar_campos()
        {
            txtuser.Text = "";
            txtpass.Text = "";
            txtnya.Text = "";
        }
    }
}
