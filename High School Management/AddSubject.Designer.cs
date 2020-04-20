namespace High_School_Management
{
    partial class AddSubject
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.textSubName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSubID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAddUser.Location = new System.Drawing.Point(187, 239);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(170, 75);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.Text = "Add Subject";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // textSubName
            // 
            this.textSubName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSubName.Location = new System.Drawing.Point(234, 164);
            this.textSubName.Margin = new System.Windows.Forms.Padding(2);
            this.textSubName.Name = "textSubName";
            this.textSubName.Size = new System.Drawing.Size(190, 30);
            this.textSubName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(84, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Subject Name :";
            // 
            // textSubID
            // 
            this.textSubID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textSubID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textSubID.Location = new System.Drawing.Point(234, 71);
            this.textSubID.Margin = new System.Windows.Forms.Padding(2);
            this.textSubID.Name = "textSubID";
            this.textSubID.Size = new System.Drawing.Size(190, 30);
            this.textSubID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(117, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Subject ID :";
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 348);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.textSubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSubID);
            this.Controls.Add(this.label1);
            this.Name = "AddSubject";
            this.Text = "Add Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox textSubName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSubID;
        private System.Windows.Forms.Label label1;
    }
}