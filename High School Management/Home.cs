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
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        List<Panel> HomePanels = new List<Panel>();
        List<Button> HomeButtons = new List<Button>();
        ToolTip t = new ToolTip();
        string user;


        public Home(string name)
        {
            InitializeComponent();
            AddItem();
            this.Name = name;
            welcome.Text = "Welcome "+name;

        }
        void AddItem()
        {
            HomePanels.Add(panelStudent);
            HomePanels.Add(panelTeacher);
            HomePanels.Add(panelResult);
            HomePanels.Add(panelUsers);
            HomePanels.Add(panelSubject);
            HomePanels.Add(panelClass);


            HomeButtons.Add(button1);
            HomeButtons.Add(button2);
            HomeButtons.Add(button3);
            HomeButtons.Add(button4);
            HomeButtons.Add(button5);
            HomeButtons.Add(button6);
            HomeButtons.Add(button7);
            HomeButtons.Add(button8);
            HomeButtons.Add(button18);

        }

        void ResetAll()
        {
            foreach (var i in HomePanels)
            {
                i.Visible = false;
            }
            foreach (var i in HomeButtons)
            {
                i.Enabled = true;
                i.BackColor = System.Drawing.Color.AliceBlue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelStudent.Visible = true;
            button3.Enabled = false;
            button3.BackColor = System.Drawing.Color.DodgerBlue;
            RefreshStudentTable();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelTeacher.Visible = true;
            button6.Enabled = false;
            button6.BackColor = System.Drawing.Color.DodgerBlue;
            RefreshTeacherTable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelResult.Visible = true;
            button7.Enabled = false;
            button7.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelUsers.Visible = true;
            button2.Enabled = false;
            button2.BackColor = System.Drawing.Color.DodgerBlue;
            RefreshUserTable();
        }

        public void RefreshStudentTable()
        {
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [viewAllStudent]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStudent.DataSource = dt;
            conn.Close();
        }
        public void RefreshTeacherTable()
        {
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [viewAllTeacher]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewTeacher.DataSource = dt;
            conn.Close();
        }
        public void RefreshUserTable()
        {
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [viewAllUser]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewUser.DataSource = dt;
            conn.Close();
        }
        public void RefreshSubjectTable(string st)
        {
            string connString;  
            if (st == "All")
                connString = "SELECT * FROM [viewAllSubject]";
            else  if(st=="sub")
                connString = "SELECT * FROM [viewAllSubject] Where [subject name] like '%" + textSubSearch.Text + "%'";
            else
                connString = "SELECT * FROM [viewAllSubject] Where [Assigned Class]= '" + st + "'";

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(connString, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSubject.DataSource = dt;
            conn.Close();
        }
        void RefreshClassTable(string st)

        {
            string connString;
            if (st == "All")
                connString = "SELECT * FROM [viewAllClass]";
            else
                connString = "SELECT * FROM [viewAllClass] Where [Class Name]= '" + st + "'";

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(connString, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewClass.DataSource = dt;
            conn.Close();
        }
        void GetComboClassData(ComboBox cmbox)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [class]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "All" };
            dt.Rows.InsertAt(dr, 0);
           cmbox.ValueMember = "class_name";
            cmbox.DisplayMember = "class_name";
            cmbox.DataSource = dt;
            conn.Close();
        }
        void GetSubTextbox()
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT subject_name FROM [subject]", conn);
            SqlDataReader dr = cmd.ExecuteReader() ;
            AutoCompleteStringCollection subCollection = new AutoCompleteStringCollection();
            while (dr.Read())
                subCollection.Add(dr.GetString(0));
            textSubSearch.AutoCompleteCustomSource = subCollection;
            dr.Close();
            conn.Close();

        }
        private void button10_Click(object sender, EventArgs e)
        {
            new AddUsers().Show();
            RefreshUserTable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new AddStudents(this).Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelSubject.Visible = true;
            button18.Enabled = false;
            button18.BackColor = System.Drawing.Color.DodgerBlue;

            GetComboClassData(comboClassList);
            GetSubTextbox();
            RefreshSubjectTable(comboClassList.GetItemText(comboClassList.SelectedItem));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void comboClassList_SelectionChangeCommitted(object sender, EventArgs e)
        {

            RefreshSubjectTable(comboClassList.GetItemText(comboClassList.SelectedItem));

        }
        private void textSubSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshSubjectTable("sub");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new AddSubject().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelClass.Visible = true;
            button5.Enabled = false;
            button5.BackColor = System.Drawing.Color.DodgerBlue; 

            GetComboClassData(comboBoxClass2);
            RefreshClassTable(comboBoxClass2.GetItemText(comboBoxClass2.SelectedItem));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResetAll();
            //panelClass.Visible = true;
            button8.Enabled = false;
            button8.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetAll();
            //panelClass.Visible = true;
            button1.Enabled = false;
            button1.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetAll();
            //panelClass.Visible = true;
            button4.Enabled = false;
            button4.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void comboBoxClass2_SelectionChangeCommitted(object sender, EventArgs e)
        {
             RefreshClassTable(comboBoxClass2.GetItemText(comboBoxClass2.SelectedItem));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            new AssignSubject().Show();
        }

        private void comboBoxClass2_MouseHover(object sender, EventArgs e)
        {
            t.Show("Select a class to show it's assigned subject", comboBoxClass2);
        }

        private void comboBoxClass2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            new EditStudent(dataGridViewStudent.CurrentRow.Cells[0].Value.ToString(),this).Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new EditUser(dataGridViewUser.CurrentRow.Cells[0].Value.ToString(), this).Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new AddTeacher(this).Visible = true;
        }
    }
    
}
