using System;

namespace Task3
{
    public partial class ChangeForm : System.Windows.Forms.Form
    {
        public Action<string, string> replaceText;

        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            replaceText?.Invoke(SearchTextBox.Text, replaceTextBox.Text);
        }


    }
}
