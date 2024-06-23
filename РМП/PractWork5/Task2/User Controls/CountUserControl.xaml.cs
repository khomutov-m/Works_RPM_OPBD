using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task2.User_Controls
{
    /// <summary>
    /// Логика взаимодействия для CountUserControl.xaml
    /// </summary>
    public partial class CountUserControl : UserControl
    {
        public int MaxValue { get; set; }
        public int Value { get; set; } = 0;
        public int UnitPrice { get; set; } = 0;
        public event RoutedEventHandler ValueChanged;

        public CountUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value < MaxValue)
            {
                CountTextBox.Text = (++Value).ToString();
                UpdatePrice();
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value > 0)
            {
                CountTextBox.Text = (--Value).ToString();
                UpdatePrice();
            }
        }

        private void CountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountTextBox.Text))
                Value = 0;
            else
            {
                if (Convert.ToInt32(CountTextBox.Text) > MaxValue)
                {
                    CountTextBox.Text = Value.ToString();
                    return;
                }
                else
                    Value = Convert.ToInt32(CountTextBox.Text);
            }

            PlusButton.IsEnabled = Value == MaxValue ? false : true;
            MinusButton.IsEnabled = Value == 0 ? false : true;
            UpdatePrice();
        }

        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!IsNumber(e.Text))
                e.Handled = true;
            else
                UpdatePrice();
        }

        private bool IsNumber(string input)
        {
            return input.All(char.IsDigit);
        }

        private void UpdatePrice()
        {
            PriceTextBlock.Text = $"Итого: {Value * UnitPrice}";
        }

        private void UnitPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(UnitPriceTextBox.Text))
            {
                UnitPrice = 0;
            }
            else
                UnitPrice = Convert.ToInt32(UnitPriceTextBox.Text);
            UpdatePrice();
        }
    }
}
