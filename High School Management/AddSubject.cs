using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class AddSubject : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        Home h;
        public AddSubject(Home h)
        {
            this.h = h;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Subject] (subject_id,subject_name) VALUES('" + textSubID.Text + "','" + textSubName.Text + "')", conn);

            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    if (textSubID.Text != "" && textSubName.Text != "")
                        MessageBox.Show("Successfully added!!!", "Succesfull");
                    else
                        MessageBox.Show("Please Fill All The Field!!!", "Incomplete");
                }
                else
                {
                    MessageBox.Show("error!!!", "Error");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            conn.Close();
        }
    }
}
