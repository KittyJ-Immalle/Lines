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
            line3.X2 = 300;
            line3.Y2 = 300;
            line3.Stroke = new SolidColorBrush(Colors.Black);

            Line line4 = new Line();
            line4.X1 = 0;
            line4.Y1 = 300;
            line4.X2 = 300;
            line4.Y2 = 300;
            line4.Stroke = new SolidColorBrush(Colors.Black);

            Line line5 = new Line();
            line5.X1 = 100;
            line5.Y1 = 0;
            line5.X2 = 100;
            line5.Y2 = 300;
            line5.Stroke = new SolidColorBrush(Colors.Black);

            Line line6 = new Line();
            line6.X1 = 200;
            line6.Y1 = 0;
            line6.X2 = 200;
            line6.Y2 = 300;
            line6.Stroke = new SolidColorBrush(Colors.Black);

            Line line7 = new Line();
            line7.X1 = 0;
            line7.Y1 = 100;
            line7.X2 = 300;
            line7.Y2 = 100;
            line7.Stroke = new SolidColorBrush(Colors.Black);

            Line line8 = new Line();
            line8.X1 = 0;
            line8.Y1 = 200;
            line8.X2 = 300;
            line8.Y2 = 200;
            line8.Stroke = new SolidColorBrush(Colors.Black);

            myCanvas.Children.Add(line1);
            myCanvas.Children.Add(line2);
            myCanvas.Children.Add(line3);
            myCanvas.Children.Add(line4);
            myCanvas.Children.Add(line5);
            myCanvas.Children.Add(line6);
            myCanvas.Children.Add(line7);
            myCanvas.Children.Add(line8);

        }
    }
}
