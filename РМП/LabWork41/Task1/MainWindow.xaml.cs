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
using System.Windows.Media.Animation;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuStackPanel.Width > 30)
            {
                DoubleAnimation menuAnimation = new DoubleAnimation();
                menuAnimation.From = MenuStackPanel.ActualWidth;
                menuAnimation.To = 30;
                menuAnimation.Duration = TimeSpan.FromSeconds(1);
                MenuStackPanel.BeginAnimation(StackPanel.WidthProperty, menuAnimation);
            }
            else
            {
                DoubleAnimation menuAnimation = new DoubleAnimation();
                menuAnimation.From = MenuStackPanel.ActualWidth;
                menuAnimation.To = 100;
                menuAnimation.Duration = TimeSpan.FromSeconds(1);
                MenuStackPanel.BeginAnimation(StackPanel.WidthProperty, menuAnimation);
            }
        }
    }
}
