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

namespace Vistas.Control_de_Usuario
{
    /// <summary>
    /// Lógica de interacción para BtnGC.xaml
    /// </summary>
    public partial class BtnGC : UserControl
    {
        public BtnGC()
        {
            InitializeComponent();
        }

        /*   public ICommand AddClick
           {
               get { return (ICommand)GetValue(AddClickProperty); }
               set { SetValue(AddClickProperty, value); }
           }
           public static readonly DependencyProperty AddClickProperty =
                       DependencyProperty.Register("AddClick", typeof(ICommand), typeof(BtnGC));


           public ICommand CancelClick
           {
               get { return (ICommand)GetValue(CancelClickProperty); }
               set { SetValue(CancelClickProperty, value); }
           }
           public static readonly DependencyProperty CancelClickProperty =
                       DependencyProperty.Register("CancelClick", typeof(ICommand), typeof(BtnGC));*/

         public string add_click { get; set; }

          public string cancel_click { get; set; }

        public string opcion { get; set; }

        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GUARDA"+opcion);
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cancela"+opcion);
        }
    }
}
