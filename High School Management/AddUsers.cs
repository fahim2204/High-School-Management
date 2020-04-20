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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textUsername.Text = "";
            textPassword.Text = "";
            comboBox1.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
            string query = "";
            query = "INSERT INTO [Users] (name,username,password,type) VALUES('" + textName.Text + "','" + textUsername.Text + "'," + textPassword.Text + ",'" + comboBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            //int result = cmd.ExecuteNonQuery();
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    if(textName.Text!=null && textUsername.Text!=null && textPassword.Text!= null && comboBox1.Text!= null)
                         MessageBox.Show("Successfully added!!!", "Succesfull");
                    else
                        MessageBox.Show("Please Fill All The Field!!!", "Incomplete");
                }
                else
                {
                    MessageBox.Show("error!!!", "Error");
                }
            }
            catch { MessageBox.Show("Please Fillup Correctly!!", "Error"); }
            conn.Close();
        }
    }
}
