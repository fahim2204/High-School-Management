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
    public partial class EditUser : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        Home h;
        String Uid;
        public EditUser(string Uid,Home h)
        {
            InitializeComponent();
            this.Uid = Uid;
            this.h = h;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from [users] where id = " + Uid + "", conn);
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Deleted Successful!!!", "Succesfull");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
                conn.Close();
                h.RefreshUserTable();
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from [users] where [ID] = '" + Uid + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            try
            {
                textName.Text = dt.Rows[0][1].ToString();
                textUsername.Text = dt.Rows[0][2].ToString();
                textPassword.Text = dt.Rows[0][3].ToString();
                comboBox1.Text = dt.Rows[0][4].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }

            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [users] set name = '" + textName.Text + "',username = '" + textUsername.Text + "',password = '" + textPassword.Text + "',type='" + comboBox1.Text + "' where id = " + Uid + "", conn);
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Update Success!!!", "Succesfull");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            conn.Close();
            h.RefreshUserTable();
        }
    }
}
