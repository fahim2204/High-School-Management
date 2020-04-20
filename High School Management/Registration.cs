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

namespace Lab_8
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            textEmail.Text = "";
            textContact.Text = "";
            //constructor of DateTime:
            //new DateTime(int year,int month,int date);
            datePick.Value = new DateTime(2000, 01, 01);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=TestDB;Integrated Security=true");
            conn.Open();
            string query = "";
            query = "INSERT INTO [User] (Name,Username,Contact,Email,Dob,Password) VALUES('" + textName.Text + "','" + textUsername.Text + "'," + textContact.Text + ",'" + textEmail.Text + "','" + datePick.Value.Date.ToString("yyyyMMdd") + "','" + textPassword.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            //int result = cmd.ExecuteNonQuery();
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Successfully added!!!", "Succesfull");
                }
                else
                {
                    MessageBox.Show("error!!!", "Error");
                }
            }
            catch { MessageBox.Show("Please Fillup Correctly!!", "Error"); }
            conn.Close();
        }

        private void textContact_KeyPress(object sender, KeyPressEventArgs e)
        {

            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                        e.Handled = true;
                }
            }
        }
    }
}
