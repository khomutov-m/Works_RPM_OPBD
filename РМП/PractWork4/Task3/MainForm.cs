﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AuthorizationToolStripButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.ShowDialog();
        }
    }
}
