using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class Student : High_School_Management.Home
    {
        public static Student obj = null;
        public static Student getObj()
        {
            if (obj == null)
                obj = new Student();
            return obj;
        }
        public Student()
        {
            this.button3.Enabled = false;
            button3.BackColor = System.Drawing.Color.DodgerBlue;
            InitializeComponent();
            RefreshTable();
        }
        void RefreshTable()
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [students]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AddStudents().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Enabled = false;
            button6.BackColor = System.Drawing.Color.DodgerBlue;
        }
    }
}
