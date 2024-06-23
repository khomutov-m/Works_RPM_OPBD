using Microsoft.Win32;
using System;
using System.IO;
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
using System.Windows.Threading;

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer;
        List<string> FilePaths = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
        }

        private void SelectMedia_Click(object sender, RoutedEventArgs e)
        {
            PlayerMediaElement.Stop();
            dispatcherTimer.Stop();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Media Files|*.mp3;*.mp4;*.M4A",
            };

            if (openFileDialog.ShowDialog() == true)
            {
                FileNamesComboBox.ItemsSource = openFileDialog.FileNames;
                PlayerMediaElement.Source = new Uri($"{FileNamesComboBox.Items[0]}");
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            PlayerMediaElement.Play();
            dispatcherTimer.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            PlayerMediaElement.Stop();
            dispatcherTimer.Stop();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            PlayerMediaElement.Pause();
            dispatcherTimer.Stop();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Content = String.Format("{0:D2}:{1:D2}:{2:D2} / ", 
                PlayerMediaElement.Position.Hours, 
                PlayerMediaElement.Position.Minutes, 
                PlayerMediaElement.Position.Seconds);
            TotalTimeLabel.Content = String.Format("{0:D2}:{1:D2}:{2:D2}", 
                PlayerMediaElement.NaturalDuration.TimeSpan.Hours, 
                PlayerMediaElement.NaturalDuration.TimeSpan.Minutes, 
                PlayerMediaElement.NaturalDuration.TimeSpan.Seconds);
        }

        private void FileNamesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlayerMediaElement.Stop();
            dispatcherTimer.Stop();
            PlayerMediaElement.Source = new Uri($"{((ComboBox)sender).SelectedItem}");
        }
    }
}
