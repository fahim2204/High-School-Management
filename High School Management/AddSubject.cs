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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
     
            SqlCommand cmd = new SqlCommand("INSERT INTO [Subject] (subject_id,subject_name) VALUES('" + textSubID.Text + "','" + textSubName.Text + "')", conn);
            
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    if (textSubID.Text != null && textSubName.Text != null )
                        MessageBox.Show("Successfully added!!!", "Succesfull");
                    else
                        MessageBox.Show("Please Fill All The Field!!!", "Incomplete");
                }
            else
                {
                    MessageBox.Show("error!!!", "Error");
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message.ToString(), "Error"); }
            conn.Close();
        }
    }
}
