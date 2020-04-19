using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginFun()
        {

            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username,password FROM [Users] WHERE Username = '" + textUsername.Text + "' AND Password = '" + textPassword.Text + "'", conn);
            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                new Home().Show();
            }
            else
            {
                MessageBox.Show("Wrong Password", "Failed");
            }

            conn.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginFun();
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                LoginFun();
            }
        }
    }
}
