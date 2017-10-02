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

namespace tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Line line1 = new Line();
            line1.X1 = 0;
            line1.Y1 = 0;
            line1.X2 = 300;
            line1.Y2 = 0;
            line1.Stroke = new SolidColorBrush(Colors.Black);

            Line line2 = new Line();
            line2.X1 = 0;
            line2.Y1 = 0;
            line2.X2 = 0;
            line2.Y2 = 300;
            line2.Stroke = new SolidColorBrush(Colors.Black);

            Line line3 = new Line();
            line3.X1 = 300;
            line3.Y1 = 0;
            line3.X2 = 0;
            line3.Y2 = 0;
            line3.Stroke = new SolidColorBrush(Colors.Black);

            myCanvas.Children.Add(line1);
            myCanvas.Children.Add(line2);
        }
    }
}
