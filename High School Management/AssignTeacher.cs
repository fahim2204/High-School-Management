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
    public partial class AssignTeacher : Form

    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
       
        public AssignTeacher()
        {
            InitializeComponent();
        }

        private void AssignTeacher_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [class] order by class_id", conn);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM [subject] order by subject_name", conn);
            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM [teacher] order by name", conn);

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();


            sda1.Fill(dt1);
            sda2.Fill(dt2);
            sda3.Fill(dt3);


            DataRow dr1 = dt1.NewRow();
            DataRow dr2 = dt2.NewRow();
            DataRow dr3 = dt3.NewRow();

            dr1.ItemArray = new object[] { 0, "--Select Class--" };
            dr2.ItemArray = new object[] { 0, "--Select Subject--" };
            dr3.ItemArray = new object[] { 0, "--Select Teacher--" };


            dt1.Rows.InsertAt(dr1, 0);
            dt2.Rows.InsertAt(dr2, 0);
            dt3.Rows.InsertAt(dr3, 0);


            comboClass.ValueMember = "class_name";
            comboClass.DisplayMember = "class_name";
            comboClass.DataSource = dt1;

            comboSubject.ValueMember = "subject_name";
            comboSubject.DisplayMember = "subject_name";
            comboSubject.DataSource = dt2;

            comboTName.ValueMember = "name";
            comboTName.DisplayMember = "name";
            comboTName.DataSource = dt3;


            conn.Close();

        }
        void RefreshTable()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select [Class Name],[Subject Name] from viewAssignedTeacher where [Name] = '" + comboTName.GetItemText(comboTName.SelectedItem) + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridViewTeacher.DataSource = dt;

            conn.Close();
        }

        private void comboTName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnAssignSub_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [teacher_subject] (id,fk_class_id,fk_subject_id) VALUES((select t_id from teacher where Name = '" + comboTName.GetItemText(comboTName.SelectedItem) + "'),(select class_id from class where class_name = '" + comboClass.GetItemText(comboClass.SelectedItem) + "'),(select subject_id from subject where subject_name = '" + comboSubject.GetItemText(comboSubject.SelectedItem) + "'))", conn);

            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Assign Success!!!", "Succesfull");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            conn.Close();
            RefreshTable();

        }
    }
}
