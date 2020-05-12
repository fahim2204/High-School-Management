using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            HomePanels.Add(panelTeacherHome);
            HomePanels.Add(panelResult);
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
               // i.BackColor = System.Drawing.Color.AliceBlue;
                i.BackColor = System.Drawing.ColorTranslator.FromHtml("#3498DB");
            }
        }

        private void TeacherHome_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            panelTeacherHome.Visible = true;
            button1.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelTeacherHome.Visible = true;
            button1.Enabled = false;
            button1.BackColor = System.Drawing.Color.DodgerBlue;
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
            if (dataGridViewStudent.Columns[e.ColumnIndex].Name == "Details")
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

        private void btnClear_Click(object sender, EventArgs e)
        {
             
        }

        private void dataGridAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "Login")
                {
                    fm.Visible = true;
                }
            }
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelResult.Visible = true;
            button2.Enabled = false;
            button2.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            panelAddResult.Visible = true;
            panelAddResult.BringToFront();

            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [exam] order by exam_id", conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            DataRow dr1 = dt1.NewRow();
            dr1.ItemArray = new object[] { 0, "--Select Exam--" };
            dt1.Rows.InsertAt(dr1, 0);
            
            comboExam.ValueMember = "exam_name";
            comboExam.DisplayMember = "exam_name";
            comboExam.DataSource = dt1;

            conn.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelAddResult.Visible = false;
        }

        private void comboExam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboClass.Enabled = true;

            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM [class] order by class_id", conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            DataRow dr1 = dt1.NewRow();
            dr1.ItemArray = new object[] { 0, "--Select Class--" };
            dt1.Rows.InsertAt(dr1, 0);
            comboClass.ValueMember = "class_name";
            comboClass.DisplayMember = "class_name";
            comboClass.DataSource = dt1;

            conn.Close();
        }

        private void comboClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridViewStudentResult.Enabled = true;
            comboSub.Enabled = true;

            conn.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM [subject] order by subject_name", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DataRow dr2 = dt2.NewRow();
            dr2.ItemArray = new object[] { 0, "--Select Subject--" };
            dt2.Rows.InsertAt(dr2, 0);
            comboSub.ValueMember = "subject_name";
            comboSub.DisplayMember = "subject_name";
            comboSub.DataSource = dt2;
            
            conn.Close();


            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select [Roll],[Name] from viewAllStudent where Class = '"+ comboClass.GetItemText(comboClass.SelectedItem) + "' order by Roll", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

           dataGridViewStudentResult.DataSource = dt;

            conn.Close();
            dataGridViewStudentResult.ClearSelection();
        }

        private void comboSub_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textMark.Enabled = true;
            textTotalMark.Enabled = true;
            textMark.Text = "0";
            textTotalMark.Text = "100";
            btnResultAdd.Enabled = true;
           // textTotalMark.Focus();
        }

        private void TeacherHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Environment.Exit(0);
        }
    }
}
