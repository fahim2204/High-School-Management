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
    public partial class Users : High_School_Management.Home
    {
        public Users()
        {
            this.button2.Enabled = false;
            button2.BackColor = System.Drawing.Color.DodgerBlue;
            InitializeComponent();
            RefreshTable();
        }
        void RefreshTable()
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Users]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AddUsers(this).Show();
            RefreshTable();
        }
    }
}
