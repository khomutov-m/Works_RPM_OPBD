using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show(DataAccessLayer.Builder.ToString());
            ResultDataGrid.ItemsSource = DataAccessLayer.GetAll("Book").DefaultView;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {

            if (Task5RadioButton.IsChecked == true &&
                int.TryParse(IdTextBox.Text, out int id) && id > 0 &&
                double.TryParse(NewPriceTextBox.Text, out double price) && price >= 0)
            {
                if (DataAccessLayer.ChangePrice(id, price))
                    MessageBox.Show($"Значение цены успешно изменено на {price}", "Успешно",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                else
                    MessageBox.Show($"Книги с id:{id} не существует", "Ошибка", 
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var Query = QueryTextBox.Text;
            if (String.IsNullOrEmpty(Query))
            {
                MessageBox.Show("Запрос не может быть пустым", "Неверный sql-запрос", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Task1RadioButton.IsChecked == true)
                ResultTextBlock.Text = DataAccessLayer.GetSelection(Query);
            if (Task2RadioButton.IsChecked == true)
                ResultDataGrid.ItemsSource = DataAccessLayer.GetTable(Query).DefaultView;
            if (Task3RadioButton.IsChecked == true)
                ResultDataGrid.ItemsSource = DataAccessLayer.GetList(Query);
            if (Task4RadioButton.IsChecked == true)
                CountChangedRows.Content = $"Число измененный строк:{DataAccessLayer.Update(Query)}";
        }

        private void QueryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(QueryTextBox.Text))
                TextBlock.Visibility = Visibility.Visible;
            else
                TextBlock.Visibility = Visibility.Collapsed;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = ToDataTable(ResultDataGrid);
            DataAccessLayer.UpdateFromTable(ref dataTable, NameTableTextBox.Text);
        }

        public static DataTable ToDataTable(DataGrid dataGrid)
        {
            var dataTable = new DataTable();
            foreach (var column in dataGrid.Columns)
            {
                if (column is DataGridTextColumn textColumn)
                {
                    dataTable.Columns.Add(textColumn.Header.ToString());
                }
            }
            foreach (var item in dataGrid.Items)
            {
                var row = dataTable.NewRow();
                foreach (var column in dataGrid.Columns)
                {
                    if (column is DataGridTextColumn textColumn)
                    {
                        var bindingPath = (textColumn.Binding as System.Windows.Data.Binding)?.Path.Path;
                        var cellValue = item.GetType().GetProperty(bindingPath)?.GetValue(item, null);
                        row[textColumn.Header.ToString()] = cellValue;
                    }
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
    }
}
