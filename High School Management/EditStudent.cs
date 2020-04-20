using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class EditStudent : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        string imgurl;
        string stID;
        string RadioValue = "Male";
        public EditStudent(string stID)
        {
            InitializeComponent();
            this.stID = stID;
            LoadData();
        }
        void LoadData()
        {

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from viewAllStudent where [ID] = '" + stID + "'", conn);
            SqlDataAdapter sda2 = new SqlDataAdapter("select photo from students where [st_id] = '" + stID + "'", conn);

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            sda.Fill(dt);
            sda2.Fill(dt2);

            try
            {
                textRoll.Text = dt.Rows[0][3].ToString();
                textName.Text = dt.Rows[0][1].ToString();
                comboClass.Text = dt.Rows[0][2].ToString();
                textFather.Text = dt.Rows[0][5].ToString();
                textMother.Text = dt.Rows[0][6].ToString();
                textContact.Text = dt.Rows[0][7].ToString();
                if (dt.Rows[0][4].ToString() == "Male")
                    radioMale.Checked = true;
                else
                    radioFemale.Checked = true;
                dateDob.Value = Convert.ToDateTime(dt.Rows[0][8].ToString());
                dateAdmit.Value = Convert.ToDateTime(dt.Rows[0][9].ToString());
                textAddress.Text = dt.Rows[0][10].ToString();
                profileImage.Image = Image.FromFile(@"..\..\StudentImages\" + dt2.Rows[0][0].ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Filter = "image files|*.jpg;*.jpeg;*.png;*.gif;*.icon;";
            DialogResult dres1 = fd1.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            profileImage.Image = Image.FromFile(fd1.FileName);
            Image img = Image.FromFile(fd1.FileName);
            imgurl = "img_" + textName.Text + "_" + comboClass.Text + "_" + textRoll.Text + ".jpg";
            img.Save(@"..\..\StudentImages\" + imgurl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [students] set Roll = " + textRoll.Text + ",Name = '" + textName.Text + "',fk_class_id = (select [class_id] from [class] where class_name = '" + comboClass.Text + "'),father = '" + textFather.Text + "',mother = '" + textMother.Text + "',contact =" + textContact.Text + ",gender = '" + RadioValue + "',dob='" + dateDob.Value.Date.ToString("yyyyMMdd") + "',admissionDate= '" + dateAdmit.Value.Date.ToString("yyyyMMdd") + "',address = '" + textAddress.Text + "' where st_id = "+stID+"", conn);
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Update Succes!!!", "Succesfull");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            conn.Close();
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            RadioValue = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            RadioValue = "Female";
        }
    }
}
