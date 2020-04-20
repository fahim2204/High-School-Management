﻿using System;
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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void dateAdmit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
            conn.Open();
            string query = "INSERT INTO [students] (Roll,Name,class,father,mother,contact,gender,dob,admissionDate,address) VALUES(" + textRoll.Text + ",'" + textName.Text + "','" + comboClass.Text + "','" + textFather.Text + "','" + textMother.Text + "'," + textContact.Text + ",'" + RadioValue + "','" + dateDob.Value.Date.ToString("yyyyMMdd") + "','" + dateAdmit.Value.Date.ToString("yyyyMMdd") + "','" + textAddress.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            
           try
             {
                 int result = cmd.ExecuteNonQuery();
                 if (result > 0)
                 {
                     MessageBox.Show("Successfully added!!!", "Succesfull");
                 }
                 else
                 {
                     MessageBox.Show("error!!!", "Error");
                 }
             }
             catch { MessageBox.Show("Please Fillup Correctly!!", "Error"); }
            conn.Close();
        }


        string RadioValue = "";


        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            RadioValue = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            RadioValue = "Female";

        }

        private void textRoll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Filter = "image files|*.jpg;*.png;*.gif;*.icon;.*;";
            DialogResult dres1 = fd1.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            //textBox4.Text = fd1.FileName;
            profileImage.Image = Image.FromFile(fd1.FileName);
        }
    }
}
