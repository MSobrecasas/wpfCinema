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
    /// Lógica de interacción para UCDatos.xaml
    /// </summary>
    public partial class UCDatos : UserControl
    {
        public UCDatos()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string TextC { get; set; }
        public String Dato
        {
            get { return txt.Text; }
        }

    }
}
