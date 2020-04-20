using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace High_School_Management
{
    public partial class AddStudents : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=school;Integrated Security=true");
        string imgurl = "default.jpg";
        Home h;

        public AddStudents(Home h)
        {
            InitializeComponent();
            this.h = h;
        }

        private void dateAdmit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }



        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO [students] (Roll,Name,fk_class_id,father,mother,contact,gender,dob,admissionDate,address,photo) VALUES(" + textRoll.Text + ",'" + textName.Text + "',(select [class_id] from [class] where class_name = '" + comboClass.Text + "'),'" + textFather.Text + "','" + textMother.Text + "'," + textContact.Text + ",'" + RadioValue + "','" + dateDob.Value.Date.ToString("yyyyMMdd") + "','" + dateAdmit.Value.Date.ToString("yyyyMMdd") + "','" + textAddress.Text + "','" + imgurl + "')";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
           {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Successfully added!!!", "Succesfull");
           }
           catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }
            h.RefreshStudentTable();
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
            fd1.Filter = "image files|*.jpg;*.jpeg;*.png;*.gif;*.icon;";
            DialogResult dres1 = fd1.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            profileImage.Image = Image.FromFile(fd1.FileName);
            Image img = Image.FromFile(fd1.FileName);
            imgurl = "img_" + textName.Text.Replace(' ', '_') + "_" + comboClass.Text + "_" + textRoll.Text + ".jpg";
            img.Save(@"..\..\StudentImages\" + imgurl);
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            radioMale.Checked = true;
            dateAdmit.Value = DateTime.Today;

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

        private void button3_Click(object sender, EventArgs e)
        {
            textRoll.Text = "";
            textName.Text = "";
            comboClass.SelectedIndex = 0;
            textFather.Text = "";
            textMother.Text = "";
            textContact.Text = "";
            radioMale.Checked = true;
            dateDob.Value = new DateTime(2000, 01, 01);
            dateAdmit.Value = DateTime.Today;
            textAddress.Text = "";
            profileImage.Image = Image.FromFile(@"..\..\StudentImages\default.jpg");
        }

    }
}
