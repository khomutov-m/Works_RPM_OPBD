using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class TextForm : System.Windows.Forms.Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ChangeForm form2 = new ChangeForm();
            form2.replaceText += ReplacedText;
            form2.ShowDialog();
        }

        private void ReplacedText(string sourceText, string textForChange)
        {
            SourceTextBox.Text = SourceTextBox.Text.Replace(sourceText, textForChange);
        }
    }
}
