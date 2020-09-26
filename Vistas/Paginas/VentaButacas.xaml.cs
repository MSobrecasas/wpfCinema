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
using System.Collections;
using ClasesBase;

namespace Vistas.Paginas {
    /// <summary>
    /// Interaction logic for VentaButacas.xaml
    /// </summary>
    public partial class VentaButacas : Page {

            int filas = 10;
            int columnas = 10;
            string nombre = "";
            string letra = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

       

        public VentaButacas() {
            
            InitializeComponent();
            generar_Butacas();
            
        }

        private void generar_Butacas() {
            
           
            Grid DynamicGrid = new Grid();
            DynamicGrid.HorizontalAlignment = HorizontalAlignment.Center;
            DynamicGrid.VerticalAlignment = VerticalAlignment.Top;
            DynamicGrid.ShowGridLines = true;
            DynamicGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);
            DynamicGrid.Margin = new Thickness(0, 0, 0, 0);
            // CREAR FILAS
            for (int i = 0; i < filas; i++)
            {
                nombre = "GridRow" + i;
                RowDefinition gridRow = new RowDefinition();
                gridRow.Name = nombre;
                gridRow.Height = new GridLength(40);
                DynamicGrid.RowDefinitions.Add(gridRow);
            }
            // CREAR COLUMNAS
             for (int j = 0; j < columnas; j++)
                {
                nombre = "GridCol" + j;
                ColumnDefinition GridCol = new ColumnDefinition();
                GridCol.Name = nombre;
                GridCol.Width = new GridLength(40);
                DynamicGrid.ColumnDefinitions.Add(GridCol);

            }
             // CREAR BOTONES
            for (int i = 0; i < filas; i++)
            {
                for (int j = 1; j < columnas+1; j++)
                {
                    Button btn = new Button();
                    btn.BorderThickness = new Thickness(2);
                    btn.Content = letra[i] + j.ToString();
                    btn.Name = "btn" + i.ToString() + j.ToString();
                    Grid.SetRow(btn,i);
                    Grid.SetColumn(btn,j-1);
                    btn.Style = (Style)Application.Current.Resources["style_butaca"];
                    DynamicGrid.Children.Add(btn);
                    btn.Click += vender_butaca;
                    
                    /// desactivar 1 boton
                    if ( i == 1 && j==3)
                    {
                        btn.Background = new SolidColorBrush(Colors.Red);
                    }
                    
                         
                }
            }
            // AGREGAR GRID CREADO AL GRID CENTRAL
            GridCentral.Children.Add(DynamicGrid);
            


        }
        private void vender_butaca(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Background = new SolidColorBrush(Colors.Green);
        }

        private void butaca_vendida()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 1; j < columnas + 1; j++)
                {
                    

                }
            }
            Butaca butaca= new Butaca();
        }

    }
}
