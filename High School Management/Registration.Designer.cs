namespace Lab_8
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.Menu;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textName.Location = new System.Drawing.Point(173, 64);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(210, 28);
            this.textName.TabIndex = 1;
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textUsername.Location = new System.Drawing.Point(173, 117);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(210, 28);
            this.textUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(60, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textEmail.Location = new System.Drawing.Point(173, 236);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(210, 28);
            this.textEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(60, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email :";
            // 
            // textContact
            // 
            this.textContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textContact.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textContact.Location = new System.Drawing.Point(173, 179);
            this.textContact.MaxLength = 11;
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(210, 28);
            this.textContact.TabIndex = 3;
            this.textContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textContact_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(60, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(60, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOB :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(60, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password :";
            // 
            // textPassword
            // 
            this.textPassword.AccessibleDescription = "";
            this.textPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textPassword.Location = new System.Drawing.Point(173, 342);
            this.textPassword.MaxLength = 15;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(210, 28);
            this.textPassword.TabIndex = 7;
            this.textPassword.Tag = "";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRegister.Location = new System.Drawing.Point(258, 426);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(133, 58);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClear.Location = new System.Drawing.Point(101, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 58);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // datePick
            // 
            this.datePick.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.datePick.CustomFormat = "dd - MM - yyyy";
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePick.Location = new System.Drawing.Point(173, 286);
            this.datePick.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.datePick.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.datePick.Name = "datePick";
            this.datePick.ShowUpDown = true;
            this.datePick.Size = new System.Drawing.Size(210, 28);
            this.datePick.TabIndex = 6;
            this.datePick.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 528);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker datePick;
    }
}

