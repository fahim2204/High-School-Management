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

        public Home()
        {
            InitializeComponent();
            AddItem();
        }
        void AddItem()
        {
            HomePanels.Add(panelStudent);
            HomePanels.Add(panelTeacher);
            HomePanels.Add(panelResult);
            HomePanels.Add(panelUsers);

            HomeButtons.Add(button1);
            HomeButtons.Add(button2);
            HomeButtons.Add(button3);
            HomeButtons.Add(button4);
            HomeButtons.Add(button5);
            HomeButtons.Add(button6);
            HomeButtons.Add(button7);
            HomeButtons.Add(button8);
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

        void RefreshStudentTable()
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [students]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStudent.DataSource = dt;
            conn.Close();
        }
        void RefreshUserTable()
        {
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", conn);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Users]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewUser.DataSource = dt;
            conn.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            new AddUsers().Show();
            RefreshUserTable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new AddStudents().Show();
        }

      
    }
}
