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

        private void comboTName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select [Class Name],[Subject Name] from viewAssignedTeacher where [Name] = '" + comboTName.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridViewTeacher.DataSource = dt;

            conn.Close();
        }
    }
}
