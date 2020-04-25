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
    public partial class EditSubject : Form
    {
        string st;
        Home h;
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");

        public EditSubject(string st,Home h)
        {
            this.st = st;
            this.h = h;
            InitializeComponent();
        }

        private void EditSubject_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from [Subject] where [subject_id] = '" + st + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            try
            {
                textSubID.Text = dt.Rows[0][0].ToString();
                textSubName.Text = dt.Rows[0][1].ToString();
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }

            conn.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from [Subject] where subject_id = " + textSubID.Text + "", conn);
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Delete Success!!!", "Succesfull");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
                conn.Close();
                h.RefreshSubjectTable("All");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [Subject] set subject_id = " + textSubID.Text + ",Subject_name = '" + textSubName.Text + "' where subject_id = " + textSubID.Text + "", conn);
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Update Success!!!", "Succesfull");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            conn.Close();
            h.RefreshSubjectTable("All");
        }
    }
}
