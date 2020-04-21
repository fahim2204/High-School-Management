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
            string query = "INSERT INTO [teacher] (Name,contact,email,gender,dob,join_date,fk_class_id,fk_subject_id,address,photo) VALUES('" + textName.Text + "'," + textContact.Text + ",'" + textEmail.Text + "','" + RadioValue + "','" + dateDob.Value.Date.ToString("yyyyMMdd") + "','" + dateAdmit.Value.Date.ToString("yyyyMMdd") + "',(select [class_id] from [class] where class_name = '" + comboClass.Text + "'),(select [subject_id] from [subject] where subject_name = '" + comboSubject.Text + "'),'" + textAddress.Text + "','" + imgurl + "')";
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

            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [class] order by class_id", conn);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM [subject] order by subject_name", conn);

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            sda1.Fill(dt1);
            sda2.Fill(dt2);

            DataRow dr1 = dt1.NewRow();
            DataRow dr2 = dt2.NewRow();
            dr1.ItemArray = new object[] { 0, "--Select Class--" };
            dr2.ItemArray = new object[] { 0, "--Select Subject--" };

            dt1.Rows.InsertAt(dr1, 0);
            dt2.Rows.InsertAt(dr2, 0);

            comboClass.ValueMember = "class_name";
            comboClass.DisplayMember = "class_name";
            comboClass.DataSource = dt1;

            comboSubject.ValueMember = "subject_name";
            comboSubject.DisplayMember = "subject_name";
            comboSubject.DataSource = dt2;


            conn.Close();
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
