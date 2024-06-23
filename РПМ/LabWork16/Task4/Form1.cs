using System;
using System.Windows.Forms;

namespace Task4
{
    public partial class NumbersForm : Form
    {
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            numbersTextBox.Text += button.Text;
        }

        public NumbersForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numbersTextBox.Clear();
        }
    }
}
