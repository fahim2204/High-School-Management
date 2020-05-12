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
    public partial class EditEmployee : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        string eid;
        Home h;
        public EditEmployee(string eid, Home h)
        {
            this.eid = eid;
            this.h = h;
            InitializeComponent();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from [employee] where [e_id] = '" + eid + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            try
            {
                textName.Text = dt.Rows[0][1].ToString();
                textDesig.Text = dt.Rows[0][2].ToString();
                textAddress.Text = dt.Rows[0][3].ToString();
                textContact.Text = dt.Rows[0][4].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }

            conn.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [employee] set name = '" + textName.Text + "',designation = '" + textDesig.Text + "',address = '" + textAddress.Text + "',contact ='" + textContact.Text + "' where e_id = " + eid + "", conn);
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Update Success!!!", "Succesfull");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            conn.Close();
            h.RefreshEployeeTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from [employee] where e_id = " + eid + "", conn);
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Deleted Successful!!!", "Succesfull");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
                conn.Close();
                h.RefreshEployeeTable();
            }
        }
    }
}
