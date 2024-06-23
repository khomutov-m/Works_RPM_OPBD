﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public delegate void ChangeTextHandler(string sourceText, string textForChange);

    public partial class ChangeForm : Form
    {
        public event ChangeTextHandler ChangeText;

        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeText?.Invoke(SourceTextBox.Text, TextBoxToChange.Text);
        }
    }
}
