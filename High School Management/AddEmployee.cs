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
    public partial class AddEmployee : Form
    {
        Home h;
        public AddEmployee(Home h)
        {
            this.h = h;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
            string query = "";
            query = "INSERT INTO [employee] (name,designation,address,contact) VALUES('" + textName.Text + "','" + textDesig.Text + "','" + textAddress.Text + "'," + textContact.Text + ")";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    if (textName.Text != null && textDesig.Text != null && textAddress.Text != null && textDesig.Text != null)
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
            h.RefreshEployeeTable();
        }
    }
}
