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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int radius = random.Next(10, 50);
            Color color = Color.FromRgb((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256)); 

            string[] tags = { "enemy", "hero", "treasure" };
            string tag = tags[random.Next(0, tags.Length)];

            Ellipse ellipse = new Ellipse
            {
                Width = radius * 2,
                Height = radius * 2,
                Fill = new SolidColorBrush(color),
                Tag = tag
            };

            Canvas.SetTop(ellipse, e.GetPosition(Canvas).Y - radius);
            Canvas.SetLeft(ellipse, e.GetPosition(Canvas).X - radius);
            ellipse.MouseRightButtonDown += Ellipse_MouseRightButtonDown;

            Canvas.Children.Add(ellipse);
        }

        private void Ellipse_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse clickedEllipse = (Ellipse)sender;
            string tag = clickedEllipse.Tag.ToString();
            MessageBox.Show($"Тэг нажатого элемента: {tag}");
        }
    }
}
