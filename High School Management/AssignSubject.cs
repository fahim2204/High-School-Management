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
    public partial class AssignSubject : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");

        public AssignSubject()
        {
            InitializeComponent();
        }

        private void AssignSubject_Load(object sender, EventArgs e)
        {
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

            comboBoxClassAssign.ValueMember = "class_name";
            comboBoxClassAssign.DisplayMember = "class_name";
            comboBoxClassAssign.DataSource = dt1;

            comboBoxSubAssign.ValueMember = "subject_name";
            comboBoxSubAssign.DisplayMember = "subject_name";
            comboBoxSubAssign.DataSource = dt2;

            conn.Close();
        }

        private void btnAssignSub_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [subject_enrolment] (fk_class_id,fk_subject_id) VALUES((select class_id from class where class_name = '" + comboBoxClassAssign.GetItemText(comboBoxClassAssign.SelectedItem) + "'),(select subject_id from subject where subject_name = '" + comboBoxSubAssign.GetItemText(comboBoxSubAssign.SelectedItem) + "'))", conn);

            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Assign Success!!!", "Succesfull");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }

            conn.Close();
            ListRefresh();

        }

        private void comboBoxClassAssign_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListRefresh();    
        }
        void ListRefresh()
        {
            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [assigned subject] FROM [viewAllClass] where [class name] = '" + comboBoxClassAssign.GetItemText(comboBoxClassAssign.SelectedItem) + "' ", conn);
            sda.Fill(ds);
            this.listAssignedClass.DataSource = ds.Tables[0];
            this.listAssignedClass.DisplayMember = "assigned subject";




            //SqlCommand cmd = new SqlCommand("SELECT [assigned subject] FROM [viewAllClass] where [class name] = 'Six' ", conn);
            // SqlDataReader dr = cmd.ExecuteReader();
            // while(dr.Read())
            // {
            //     listAssignedClass.Items.Add(dr["assigned subject"]);
            //  }



            // SqlDataAdapter sda = new SqlDataAdapter("SELECT [assigned subject] FROM [viewAllClass] where [class name] = 'Six' ", conn);
            // DataSet dt = new DataSet();
            // sda.Fill(dt);
            // DataRow dr = dt.NewRow();
            // dr.ItemArray = new object[] { 0, "+++All Assigned Subject Under This Class+++" };
            // dt.Rows.InsertAt(dr, 0);
            // listAssignedClass.ValueMember = "assigned class";
            // listAssignedClass.DisplayMember = "assigned class";
            //listAssignedClass.DataSource = dt.Tables[0];
            conn.Close();

        }
    }
}
