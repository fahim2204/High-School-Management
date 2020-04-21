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
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Users] WHERE Username = '" + textUsername.Text + "' AND Password = '" + textPassword.Text + "'", conn);
            SqlDataReader da = cmd.ExecuteReader();

            if (textUsername.Text == "" && textPassword.Text == "")
                MessageBox.Show("Must Have A UserName & Password!!!", "Error");
            else if(textUsername.Text=="")
                MessageBox.Show("Must Have A UserName!!!", "Error");
            else if (textPassword.Text == "")
                MessageBox.Show("Must Have A Password!!!", "Error");

            else if (da.Read())
            {
                if(da["type"].ToString()=="admin")
                {
                    bool IsOpen = false;
                    foreach(Form f in Application.OpenForms)
                    {
                        if(f.Text=="Home")
                        {
                            IsOpen = true;
                            f.BringToFront();
                            break;
                        }
                    }

                    if (!IsOpen)
                    {
                        Home h = new Home(da["name"].ToString());
                        h.Show();
                    }

                }
                else if (da["type"].ToString() == "teacher")
                {
                    TeacherHome h = new TeacherHome(da["name"].ToString());
                    h.Show();

                }
                else if (da["type"].ToString() == "student")
                {
                    Home h = new Home(da["name"].ToString());
                    h.Show();

                }
                else
                {
                    MessageBox.Show("Something Went Wrong!!!", "Error");
                }

            }
            else
            {
                MessageBox.Show("Wrong Password or Username", "Failed");
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
