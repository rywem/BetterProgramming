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

namespace AlgorithmsWPF
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

        private void GenerateRandomPoints_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle { Width = 5, Height = 5, Fill = Brushes.Blue };
            MainCanvas.Children.Add(rect);
            Canvas.SetLeft(rect, 5.0);
            Canvas.SetTop(rect, 5.0);

            Point p = new Point();
            p.X = 20;
            p.Y = 20;
            
        }
    }
}
