namespace High_School_Management
{
    partial class AddTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher));
            this.button1 = new System.Windows.Forms.Button();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.dateAdmit = new System.Windows.Forms.DateTimePicker();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(597, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // profileImage
            // 
            this.profileImage.BackColor = System.Drawing.Color.CadetBlue;
            this.profileImage.Image = ((System.Drawing.Image)(resources.GetObject("profileImage.Image")));
            this.profileImage.Location = new System.Drawing.Point(507, 50);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(180, 200);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 39;
            this.profileImage.TabStop = false;
            // 
            // dateAdmit
            // 
            this.dateAdmit.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateAdmit.CustomFormat = "dd - MM - yyyy";
            this.dateAdmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdmit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAdmit.Location = new System.Drawing.Point(191, 346);
            this.dateAdmit.Margin = new System.Windows.Forms.Padding(2);
            this.dateAdmit.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateAdmit.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateAdmit.Name = "dateAdmit";
            this.dateAdmit.ShowUpDown = true;
            this.dateAdmit.Size = new System.Drawing.Size(263, 31);
            this.dateAdmit.TabIndex = 35;
            this.dateAdmit.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // dateDob
            // 
            this.dateDob.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateDob.CustomFormat = "dd - MM - yyyy";
            this.dateDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDob.Location = new System.Drawing.Point(191, 283);
            this.dateDob.Margin = new System.Windows.Forms.Padding(2);
            this.dateDob.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dateDob.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateDob.Name = "dateDob";
            this.dateDob.ShowUpDown = true;
            this.dateDob.Size = new System.Drawing.Size(263, 31);
            this.dateDob.TabIndex = 34;
            this.dateDob.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 403);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Contact :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Joining Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date of Birth :";
            // 
            // textAddress
            // 
            this.textAddress.AcceptsReturn = true;
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(191, 403);
            this.textAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(263, 90);
            this.textAddress.TabIndex = 36;
            this.textAddress.Text = "Haluaghat";
            // 
            // textContact
            // 
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContact.Location = new System.Drawing.Point(191, 158);
            this.textContact.Margin = new System.Windows.Forms.Padding(2);
            this.textContact.MaxLength = 11;
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(263, 31);
            this.textContact.TabIndex = 22;
            this.textContact.Text = "01960839343";
            // 
            // textEmail
            // 
            this.textEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(191, 219);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(263, 31);
            this.textEmail.TabIndex = 20;
            this.textEmail.Text = "fahim@gmail.com";
            // 
            // textName
            // 
            this.textName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(191, 33);
            this.textName.Margin = new System.Windows.Forms.Padding(2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(263, 31);
            this.textName.TabIndex = 18;
            this.textName.Text = "FAHIM FAISAL";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Location = new System.Drawing.Point(555, 367);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 52);
            this.button3.TabIndex = 38;
            this.button3.Text = "Clear All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddStudent.Location = new System.Drawing.Point(555, 441);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(132, 52);
            this.btnAddStudent.TabIndex = 37;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(191, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(217, 50);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(112, 11);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(101, 29);
            this.radioFemale.TabIndex = 9;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(14, 11);
            this.radioMale.Margin = new System.Windows.Forms.Padding(2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(77, 29);
            this.radioMale.TabIndex = 8;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(748, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.dateAdmit);
            this.Controls.Add(this.dateDob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddTeacher";
            this.Text = "Add Teacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.DateTimePicker dateAdmit;
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
    }
}