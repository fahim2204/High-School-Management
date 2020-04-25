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
    public partial class TeacherHome : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        List<Panel> HomePanels = new List<Panel>();
        List<Button> HomeButtons = new List<Button>();
        string name;
        public TeacherHome(string name)
        {
            InitializeComponent();
            AddItem();
            this.Name = name;
            welcome.Text = "Welcome " + name;
        }

        void AddItem()
        {
            HomePanels.Add(panelStudent);
            HomePanels.Add(panelAttendance);
           // HomePanels.Add(panelResult);
           // HomePanels.Add(panelUsers);
           // HomePanels.Add(panelSubject);
           // HomePanels.Add(panelClass);


            HomeButtons.Add(button1);
            HomeButtons.Add(button2);
            HomeButtons.Add(button3);
            HomeButtons.Add(button4);
            HomeButtons.Add(button5);
           // HomeButtons.Add(button6);
           // HomeButtons.Add(button7);
           // HomeButtons.Add(button8);
           // HomeButtons.Add(button18);

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

        private void TeacherHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void RefreshStudentTable()
        {
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [viewAllStudent]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStudent.DataSource = dt;
            dataGridViewStudent.AutoGenerateColumns = false;

            conn.Close();

            DataGridViewLinkColumn Details = new DataGridViewLinkColumn();

            Details.UseColumnTextForLinkValue = true;
            Details.LinkBehavior = LinkBehavior.SystemDefault;
            Details.HeaderText = "Details";
            Details.Name = "Details";
            Details.LinkColor = Color.Blue;
            Details.TrackVisitedState = true;
            Details.Text = "Details";
            Details.UseColumnTextForLinkValue = true;
            
            if (dataGridViewStudent.Columns["Details"] == null)
            {
                dataGridViewStudent.Columns.Add(Details);
            }
        }
        public void RefreshStudentTable(string type,string value)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [viewAllStudent] where ["+type+"] like '%"+value+"%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStudent.DataSource = dt;
            dataGridViewStudent.AutoGenerateColumns = false; 
            conn.Close();

            DataGridViewLinkColumn Details = new DataGridViewLinkColumn();


            Details.UseColumnTextForLinkValue = true;
            Details.LinkBehavior = LinkBehavior.SystemDefault;
            Details.HeaderText = "Details";
            Details.Name = "Details";
            Details.LinkColor = Color.Blue;
            Details.TrackVisitedState = true;
            Details.Text = "Details";
            Details.UseColumnTextForLinkValue = true;

            if (dataGridViewStudent.Columns["Details"] == null)
            {
                dataGridViewStudent.Columns.Add(Details);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboSearchType.SelectedIndex = 1;
            ResetAll();
            panelStudent.Visible = true;
            button3.Enabled = false;
            button3.BackColor = System.Drawing.Color.DodgerBlue;
            RefreshStudentTable();
        }

        private void textSubSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboSearchType.GetItemText(comboSearchType.SelectedItem) == "Roll")
                RefreshStudentTable("Roll",textSearch.Text);
            else if(comboSearchType.GetItemText(comboSearchType.SelectedItem) == "Name")
                RefreshStudentTable("Name", textSearch.Text);
            else if (comboSearchType.GetItemText(comboSearchType.SelectedItem) == "Class")
                RefreshStudentTable("Class", textSearch.Text);
            else if (comboSearchType.GetItemText(comboSearchType.SelectedItem) == "Contact")
                RefreshStudentTable("Contact", textSearch.Text);

        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new EditStudent(dataGridViewStudent.CurrentRow.Cells[0].Value.ToString()).Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelAttendance.Visible = true;
            button4.Enabled = false;
            button4.BackColor = System.Drawing.Color.DodgerBlue;
            LoadDataClass();
            RefreshAttendance();
        }
        void RefreshAttendance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Roll,Name FROM [viewAllStudent] where [Class]= '" + comboBoxClassAssign.GetItemText(comboBoxClassAssign.SelectedItem) + "' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridAttendance.DataSource = dt;
            dataGridAttendance.AutoGenerateColumns = false;
            conn.Close();

            DataGridViewCheckBoxColumn Present = new DataGridViewCheckBoxColumn();

            //DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            ///delete.HeaderText = "Delete";
            //delete.Name = "Delete";
            // delete.Text = "Delete";
            // delete.FlatStyle = FlatStyle.Popup;
            // delete.UseColumnTextForButtonValue = true;
            // delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // delete.CellTemplate.Style.BackColor = Color.Red;
            
            Present.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Present.HeaderText = "Present";
            Present.Name = "Present";
            if (dataGridAttendance.Columns["Present"] == null)
            {
                dataGridAttendance.Columns.Add(Present);
            }

        }
        void LoadDataClass()
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
            dateAttendance.Value = DateTime.Today;

        }
        void LoadDataSubject()
        {
            conn.Open();
            //SqlDataAdapter sda2 = new SqlDataAdapter("SELECT distinct [Subject Name] FROM [viewAllSubject] where [Assigned Class] = '" + comboBoxClassAssign.GetItemText(comboBoxClassAssign.SelectedItem)+ "' order by [Subject Name]", conn);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM [Subject]  order by [subject_name]", conn);

            DataTable dt2 = new DataTable();

            sda2.Fill(dt2);

            DataRow dr2 = dt2.NewRow();
            dr2.ItemArray = new object[] { 0, "--Select Subject--" };

            dt2.Rows.InsertAt(dr2, 0);

            comboBoxSubAssign.ValueMember = "subject_name";
            comboBoxSubAssign.DisplayMember = "subject_name";
            comboBoxSubAssign.DataSource = dt2;

            conn.Close();
        }

        private void comboBoxClassAssign_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshAttendance();
            LoadDataSubject();
        }
    }
}
