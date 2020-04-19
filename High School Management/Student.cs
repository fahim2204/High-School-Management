using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class Student : High_School_Management.Home
    {
        public Student()
        {
            //Home.button3.Enabled = false;
            Home h = new Home();
            h.button3.Enabled = false;
            InitializeComponent();
        }

    }
}
