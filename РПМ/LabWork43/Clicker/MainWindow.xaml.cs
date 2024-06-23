using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Clicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);
        int cookie = 0;
        int grandmother = 0;
        int price = 15;

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
            Grandmother.IsEnabled = false;
            Grandmother.Opacity = 0.5;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            CookieClickAdd();
        }

        private void Cookie_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CookieClickAdd();
        }

        private void CookieClickAdd()
        {
            CountClickLabel.Content = ++cookie;
            Grandmother.IsEnabled = (cookie >= price);
            Grandmother.Opacity = (cookie >= price) ? 1 : 0.5;
        }

        private void Grandmother_MouseDown(object sender, MouseButtonEventArgs e)
        {
            cookie -= price;
            CountClickLabel.Content = cookie;
            Grandmother.IsEnabled = (cookie >= price);
            Grandmother.Opacity = (cookie >= price) ? 1 : 0.5;

            CountGrandmotherLabel.Content = ++grandmother;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / (grandmother + 1));
            timer.Start();
        }
    }
}