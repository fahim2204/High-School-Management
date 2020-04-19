﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Student().Show();
            button3.BackColor = System.Drawing.Color.DarkOrange;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Results().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Users().Show();
        }
    }
}
