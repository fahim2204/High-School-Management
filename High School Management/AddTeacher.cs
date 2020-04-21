using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class AddTeacher : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        string imgurl = "default.jpg";
        private Home h;
        string RadioValue = "";

        public AddTeacher(Home home)
        {
            InitializeComponent();
            this.h = home;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO [teacher] (Name,contact,email,gender,dob,join_date,address,photo) VALUES('" + textName.Text + "'," + textContact.Text + ",'" + textEmail.Text + "','" + RadioValue + "','" + dateDob.Value.Date.ToString("yyyyMMdd") + "','" + dateAdmit.Value.Date.ToString("yyyyMMdd") + "','" + textAddress.Text + "','" + imgurl + "')";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Successfully added!!!", "Succesfull");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            h.RefreshTeacherTable();
            conn.Close();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            radioMale.Checked = true;
            dateAdmit.Value = DateTime.Today;
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            RadioValue = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            RadioValue = "Female";
        }
    }
}
