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

namespace WpfContainersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button btn1 = new Button()
            {
                Content = "5",
                Background = new SolidColorBrush(Colors.Yellow),
                FontSize = 36
            };
            //wrap.Children.Add(btn1);
            //dock.Children.Add(btn1);
            //DockPanel.SetDock(btn1, Dock.Top);

            //grid.RowDefinitions.Add(new RowDefinition());
            //grid.ColumnDefinitions.Add(new ColumnDefinition());

            //grid.Children.Add(btn1);
            //Grid.SetRow(btn1, 1);
            //Grid.SetColumn(btn1, 1);
            //Grid.SetRowSpan(btn1, 2);

            canvas.Children.Add(btn1);
            Canvas.SetTop(btn1, 60);
            Canvas.SetRight(btn1, 50);
        }
    }
}
