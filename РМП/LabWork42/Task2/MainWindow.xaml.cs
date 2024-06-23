using Microsoft.Win32;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Windows.Threading;

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] imagePaths;
        private int currentImageIndex = 0;
        DispatcherTimer dispatcherTimer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectImages_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog 
            {
                Multiselect=true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
            };

            if (openFileDialog.ShowDialog() == true)
            {
                if (openFileDialog.FileNames.Length >= 5)
                {
                    imagePaths = openFileDialog.FileNames;
                }
                else
                {
                    MessageBox.Show("Нужно выбрать не менее 5 изображений", "Недостаточно изображений",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
                dispatcherTimer.Interval = TimeSpan.FromSeconds(0.3);
                dispatcherTimer.Start();
            }
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex == imagePaths.Length)
            {
                currentImageIndex = 0;
            }
            imageControl.Source = new BitmapImage(new Uri(imagePaths[currentImageIndex]));
            currentImageIndex++;
        }
    }
}
