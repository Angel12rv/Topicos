﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rivera
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1 != null)
                MessageBox.Show("Estas seguro?", "Rivera", MessageBoxButtons.OKCancel);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
