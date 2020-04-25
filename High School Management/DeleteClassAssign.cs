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
    public partial class DeleteClassAssign : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");

        public DeleteClassAssign()
        {
            InitializeComponent();
        }

        private void EditClassAssign_Load(object sender, EventArgs e)
        {
            dataGridViewClass.Visible = false;
            LoadClass();
        }
        void RefreshTable()
        {
            

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [Class Name],[Assigned Subject] FROM [viewAllClass] where [class name]='" + comboBoxClassAssign.GetItemText(comboBoxClassAssign.SelectedItem) + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewClass.DataSource = dt;
            dataGridViewClass.AutoGenerateColumns = false;   ////Here was my problem. The grid autogenarate column as the index is change for this i can't manipulate.

            conn.Close();

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Name = "Delete";
            delete.Text = "Delete";
            delete.FlatStyle = FlatStyle.Popup;
            delete.UseColumnTextForButtonValue = true;
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            delete.CellTemplate.Style.BackColor = Color.Red;
            if (dataGridViewClass.Columns["Delete"] == null)
             {
                dataGridViewClass.Columns.Add(delete);
             }

           
        }
        void LoadClass()
        {
            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [class] order by class_id", conn);

            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            DataRow dr1 = dt1.NewRow();
            dr1.ItemArray = new object[] { 0, "--Select Class--" };
            dt1.Rows.InsertAt(dr1, 0);

            comboBoxClassAssign.ValueMember = "class_name";
            comboBoxClassAssign.DisplayMember = "class_name";
            comboBoxClassAssign.DataSource = dt1;

            conn.Close();

        }

        private void comboBoxClassAssign_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridViewClass.Visible = true;
            RefreshTable();
        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (e.ColumnIndex == dataGridViewClass.Columns["Delete"].Index)
           if(dataGridViewClass.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                { 
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from [subject_enrolment] where fk_subject_id = (select subject_id from Subject where subject_name = '" + dataGridViewClass.SelectedCells[1].Value.ToString() + "') and fk_class_id = (select class_id from class where class_name = '" + dataGridViewClass.SelectedCells[0].Value.ToString() + "') ", conn);
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Delete Success!!!", "Succesfull");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
                    conn.Close();
                    RefreshTable();
                }
            }
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
