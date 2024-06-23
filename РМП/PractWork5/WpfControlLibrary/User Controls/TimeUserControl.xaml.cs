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
using System.Windows.Threading;

namespace WpfControlLibrary.User_Controls
{
    /// <summary>
    /// Логика взаимодействия для TimeUserControl.xaml
    /// </summary>
    public partial class TimeUserControl : UserControl
    {
        public TimeUserControl()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Content = String.Format("{0:D2}:{1:D2}:{2:D2}",
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second);
        }
    }
}
