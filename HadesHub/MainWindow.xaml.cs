using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HadesHub
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            boardGrid grid = new boardGrid(4, 4, new Widget[1]);
            for (int row = 0; row < grid.ySize; row++)
            {
                for (int column = 0; column < grid.xSize; column++)
                {
                    Ellipse ellipse = new Ellipse
                    {
                        Stroke = Brushes.Black,
                        Fill = Brushes.Black,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Width = 5,
                        Height = 5
                        // Set other properties as needed
                    };
                    ColumnDefinition tmpCol = new ColumnDefinition();
                    
                    myGrid.ColumnDefinitions.Add(new ColumnDefinition());
                    myGrid.RowDefinitions.Add(new RowDefinition());
                    Grid.SetRow(ellipse, row);
                    Grid.SetColumn(ellipse, column);
                    myGrid.Children.Add(ellipse);
                }
            }
        }
    }
}
