using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        List<Panel> HomePanels = new List<Panel>();
        List<Button> HomeButtons = new List<Button>();
        ToolTip t = new ToolTip();
        Login login;
       


        public Home(string name,Login login)
        {
            InitializeComponent();
            AddItem();
            welcome.Text = "Welcome "+name;
            //login.Dispose();
            login.Visible = false;

        }
        void AddItem()
        {
            HomePanels.Add(panelStudent);
            HomePanels.Add(panelTeacher);
            HomePanels.Add(panelResult);
            HomePanels.Add(panelUsers);
            HomePanels.Add(panelSubject);
            HomePanels.Add(panelClass);
            HomePanels.Add(panelTeacherHome);
            HomePanels.Add(panelEmployee);


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
                //i.BackColor = System.Drawing.Color.AliceBlue;
                i.BackColor = System.Drawing.ColorTranslator.FromHtml("#3498DB");
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
        public void RefreshEployeeTable()
        {
           
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [employee]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
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
            new AddSubject(this).Show();
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
            panelEmployee.Visible = true;
            button8.Enabled = false;
            button8.BackColor = System.Drawing.Color.DodgerBlue;
            RefreshEployeeTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetAll();
            panelTeacherHome.Visible = true;
            button1.Enabled = false;
            button1.BackColor = System.Drawing.Color.DodgerBlue;
            LoadHomePanel();
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

        private void button19_Click(object sender, EventArgs e)
        {
            new AssignTeacher().Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            new EditSubject(dataGridViewSubject.CurrentRow.Cells[0].Value.ToString(), this).Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            new DeleteClassAssign().Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {

        }
       
        private void Home_Load(object sender, EventArgs e)
        {
            LoadHomePanel();
            panelTeacherHome.Visible = true;
            button1.Enabled = false;
            button1.BackColor = System.Drawing.Color.DodgerBlue;
        }
        void LoadHomePanel()
        {
            conn.Open();

            SqlCommand cmd1 = new SqlCommand("select count(*)[count] from [users]", conn);
            SqlCommand cmd2 = new SqlCommand("select count(*)[count] from [students]", conn);
            SqlCommand cmd3 = new SqlCommand("select count(*)[count] from [Subject]", conn);
            SqlCommand cmd4 = new SqlCommand("select count(*)[count] from [class]", conn);
            SqlCommand cmd5 = new SqlCommand("select count(*)[count] from [teacher]", conn);
            SqlCommand cmd6 = new SqlCommand("select count(*)[count] from [employee]", conn);

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
                TUser.Text = dr1["count"].ToString();
            dr1.Close();


            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
                TStudent.Text = dr2["count"].ToString();
            dr2.Close();


            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
                TSubject.Text = dr3["count"].ToString();
            dr3.Close();


            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
                TClass.Text = dr4["count"].ToString();
            dr4.Close();


            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
                TTeacher.Text = dr5["count"].ToString();
            dr5.Close();


            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
                TEmployee.Text = dr6["count"].ToString();
            dr6.Close();



            conn.Close();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            new AddEmployee(this).Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            new EditEmployee(dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString(), this).Visible = true;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Environment.Exit(0);
            //Application.ExitThread();
            //e.Cancel = false;
            //Close();
        }
    }
    
}
