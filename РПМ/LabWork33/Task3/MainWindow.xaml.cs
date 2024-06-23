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

namespace Task3
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
                 new Game{IdGame = 3, Name = "Pac-man", Site = "https:\\Pacman.com", Category = "аркада", Price = 300},
                 new Game{IdGame = 4, Name = "Arkanoid",Site="https:\\arcanoid.com", Category = "аркада", Price = 400},
                 new Game{IdGame = 5, Name = "Mario", Site = "https:\\mario.com", Category = "платформер", Price = 1000},
            };
            List<Category> categories = new List<Category>
            {
                 new Category{Name = "платформер", Description = "описание жанра платформер"},
                 new Category{Name = "RPG", Description = "описание жанра RPG"},
                 new Category{Name = "аркада", Description = "описание жанра аркада"}
            };
            GamesDataGrid.ItemsSource = games;
            CategoryDataGridComboBoxColumn.ItemsSource = categories;
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.DataContext is Game game)
            {
                MessageBox.Show($"ID: {game.IdGame}\nName: {game.Name}\nSite: {game.Site}\nCategory: {game.Category}\nPrice: {game.Price}");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryDataGridComboBoxColumn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}