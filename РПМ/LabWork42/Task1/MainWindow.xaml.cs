using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

        private void LoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == true)
            {
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
                inkCanvas.Background = imageBrush;
            }
        }

        private void PenSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var CurrentValue = Math.Round(PenSizeSlider.Value);
            SizePenTextBlock.Text = $"Размер({CurrentValue})";
            inkCanvas.DefaultDrawingAttributes.Width = CurrentValue;
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = ColorComboBox.SelectedItem as ComboBoxItem;
            string SelectedColor = Convert.ToString(selectedItem.Content);
            inkCanvas.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(SelectedColor);
        }
    }
}
