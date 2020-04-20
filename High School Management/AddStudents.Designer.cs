namespace High_School_Management
{
    partial class AddStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudents));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textRoll = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textFather = new System.Windows.Forms.TextBox();
            this.textMother = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateAdmit = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(397, 401);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(397, 336);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clear All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textRoll
            // 
            this.textRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textRoll.Location = new System.Drawing.Point(153, 37);
            this.textRoll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRoll.MaxLength = 3;
            this.textRoll.Name = "textRoll";
            this.textRoll.Size = new System.Drawing.Size(164, 23);
            this.textRoll.TabIndex = 1;
            this.textRoll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRoll_KeyPress);
            // 
            // textName
            // 
            this.textName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textName.Location = new System.Drawing.Point(153, 76);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(164, 23);
            this.textName.TabIndex = 2;
            // 
            // textFather
            // 
            this.textFather.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textFather.Location = new System.Drawing.Point(153, 160);
            this.textFather.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFather.Name = "textFather";
            this.textFather.Size = new System.Drawing.Size(164, 23);
            this.textFather.TabIndex = 4;
            // 
            // textMother
            // 
            this.textMother.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textMother.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textMother.Location = new System.Drawing.Point(153, 200);
            this.textMother.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMother.Name = "textMother";
            this.textMother.Size = new System.Drawing.Size(164, 23);
            this.textMother.TabIndex = 5;
            // 
            // textContact
            // 
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textContact.Location = new System.Drawing.Point(153, 238);
            this.textContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textContact.MaxLength = 11;
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(164, 23);
            this.textContact.TabIndex = 6;
            this.textContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textContact_KeyPress);
            // 
            // comboClass
            // 
            this.comboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten"});
            this.comboClass.Location = new System.Drawing.Point(153, 118);
            this.comboClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(164, 24);
            this.comboClass.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(153, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(164, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(82, 10);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
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
            this.radioMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 8;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // dateDob
            // 
            this.dateDob.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateDob.CustomFormat = "dd - MM - yyyy";
            this.dateDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDob.Location = new System.Drawing.Point(153, 310);
            this.dateDob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDob.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dateDob.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateDob.Name = "dateDob";
            this.dateDob.ShowUpDown = true;
            this.dateDob.Size = new System.Drawing.Size(164, 23);
            this.dateDob.TabIndex = 10;
            this.dateDob.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(55, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date of Birth :";
            // 
            // dateAdmit
            // 
            this.dateAdmit.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateAdmit.CustomFormat = "dd - MM - yyyy";
            this.dateAdmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateAdmit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAdmit.Location = new System.Drawing.Point(153, 349);
            this.dateAdmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateAdmit.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateAdmit.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateAdmit.Name = "dateAdmit";
            this.dateAdmit.ShowUpDown = true;
            this.dateAdmit.Size = new System.Drawing.Size(164, 23);
            this.dateAdmit.TabIndex = 11;
            this.dateAdmit.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateAdmit.ValueChanged += new System.EventHandler(this.dateAdmit_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(100, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(41, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mother\'s Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Father\'s Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(99, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(110, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Roll :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(85, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contact :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(86, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(23, 349);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Date of Admission :";
            // 
            // textAddress
            // 
            this.textAddress.AcceptsReturn = true;
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textAddress.Location = new System.Drawing.Point(153, 388);
            this.textAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(164, 66);
            this.textAddress.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(81, 388);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Address :";
            // 
            // profileImage
            // 
            this.profileImage.Image = ((System.Drawing.Image)(resources.GetObject("profileImage.Image")));
            this.profileImage.Location = new System.Drawing.Point(349, 37);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(180, 200);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 15;
            this.profileImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.dateAdmit);
            this.Controls.Add(this.dateDob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textMother);
            this.Controls.Add(this.textFather);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textRoll);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddStudents";
            this.Text = "Add Students";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textRoll;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textFather;
        private System.Windows.Forms.TextBox textMother;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateAdmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.Button button1;
    }
}