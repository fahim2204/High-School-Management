namespace High_School_Management
{
    partial class AssignSubject
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
            this.btnAssignSub = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClassAssign = new System.Windows.Forms.ComboBox();
            this.comboBoxSubAssign = new System.Windows.Forms.ComboBox();
            this.listAssignedClass = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssignSub
            // 
            this.btnAssignSub.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAssignSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAssignSub.Location = new System.Drawing.Point(369, 308);
            this.btnAssignSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignSub.Name = "btnAssignSub";
            this.btnAssignSub.Size = new System.Drawing.Size(170, 75);
            this.btnAssignSub.TabIndex = 22;
            this.btnAssignSub.Text = "Assign Subject";
            this.btnAssignSub.UseVisualStyleBackColor = false;
            this.btnAssignSub.Click += new System.EventHandler(this.btnAssignSub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(270, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Subject Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(286, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Class Name :";
            // 
            // comboBoxClassAssign
            // 
            this.comboBoxClassAssign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxClassAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxClassAssign.FormattingEnabled = true;
            this.comboBoxClassAssign.Location = new System.Drawing.Point(420, 106);
            this.comboBoxClassAssign.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClassAssign.Name = "comboBoxClassAssign";
            this.comboBoxClassAssign.Size = new System.Drawing.Size(198, 33);
            this.comboBoxClassAssign.TabIndex = 25;
            this.comboBoxClassAssign.SelectionChangeCommitted += new System.EventHandler(this.comboBoxClassAssign_SelectionChangeCommitted);
            // 
            // comboBoxSubAssign
            // 
            this.comboBoxSubAssign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSubAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxSubAssign.FormattingEnabled = true;
            this.comboBoxSubAssign.Location = new System.Drawing.Point(420, 199);
            this.comboBoxSubAssign.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSubAssign.Name = "comboBoxSubAssign";
            this.comboBoxSubAssign.Size = new System.Drawing.Size(198, 33);
            this.comboBoxSubAssign.TabIndex = 26;
            // 
            // listAssignedClass
            // 
            this.listAssignedClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listAssignedClass.FormattingEnabled = true;
            this.listAssignedClass.ItemHeight = 25;
            this.listAssignedClass.Location = new System.Drawing.Point(31, 79);
            this.listAssignedClass.Name = "listAssignedClass";
            this.listAssignedClass.Size = new System.Drawing.Size(208, 329);
            this.listAssignedClass.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(11, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Assigned Subjects :";
            // 
            // AssignSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listAssignedClass);
            this.Controls.Add(this.comboBoxSubAssign);
            this.Controls.Add(this.comboBoxClassAssign);
            this.Controls.Add(this.btnAssignSub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignSubject";
            this.Text = "AssignSubject";
            this.Load += new System.EventHandler(this.AssignSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssignSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClassAssign;
        private System.Windows.Forms.ComboBox comboBoxSubAssign;
        private System.Windows.Forms.ListBox listAssignedClass;
        private System.Windows.Forms.Label label3;
    }
}