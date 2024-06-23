using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new List<Game>
            {
                 new Game{IdGame = 1, Name = "Tetris", Site="https:\\tetris.com", Category = "головоломка", Price = 150},
                 new Game{IdGame = 2, Name = "Flappy Bird", Site="https:\\fluppybird.com", Category = "платформер", Price = 10},
                 new Game{IdGame = 3, Name = "Pac-man", Site = "Https:\\Pacman.com", Category = "аркада", Price = 300},
                 new Game{IdGame = 4, Name = "Arkanoid",Site="https:\\arcanoid.com", Category = "аркада", Price = 400},
                 new Game{IdGame = 5, Name = "Mario", Site = "https:\\mario.com", Category = "платформер", Price = 1000},
            };
            GamesDataGrid.ItemsSource = games;
        }
    }
}