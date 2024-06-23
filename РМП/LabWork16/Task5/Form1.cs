using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task5
{
    public partial class ChangeTextForm : Form
    {
        public ChangeTextForm()
        {
            InitializeComponent();
        }

        public void ChangedText(string sourceText, string textForChange)
        {
            changedTextBox.Text = changedTextBox.Text.Replace(sourceText, textForChange);
        }

        private void ChangeTextButton_Click(object sender, EventArgs e)
        {
            ChangeForm form2 = new ChangeForm();
            form2.ChangeText += ChangedText;
            form2.ShowDialog();
        }
    }
}
