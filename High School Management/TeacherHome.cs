using System;
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
    public partial class TeacherHome : Form
    {
        string name;
        public TeacherHome(string name)
        {
            InitializeComponent();
            this.Name = name;
            welcome.Text = "Welcome " + name;
        }

        private void TeacherHome_Load(object sender, EventArgs e)
        {

        }
    }
}
