namespace High_School_Management
{
    partial class DeleteClassAssign
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClassAssign = new System.Windows.Forms.ComboBox();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select Class :";
            // 
            // comboBoxClassAssign
            // 
            this.comboBoxClassAssign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxClassAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxClassAssign.FormattingEnabled = true;
            this.comboBoxClassAssign.Location = new System.Drawing.Point(160, 28);
            this.comboBoxClassAssign.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClassAssign.Name = "comboBoxClassAssign";
            this.comboBoxClassAssign.Size = new System.Drawing.Size(198, 33);
            this.comboBoxClassAssign.TabIndex = 32;
            this.comboBoxClassAssign.SelectionChangeCommitted += new System.EventHandler(this.comboBoxClassAssign_SelectionChangeCommitted);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.AllowUserToResizeRows = false;
            this.dataGridViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClass.ColumnHeadersHeight = 30;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewClass.Location = new System.Drawing.Point(20, 96);
            this.dataGridViewClass.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewClass.MultiSelect = false;
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClass.RowHeadersWidth = 51;
            this.dataGridViewClass.RowTemplate.Height = 24;
            this.dataGridViewClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClass.ShowEditingIcon = false;
            this.dataGridViewClass.Size = new System.Drawing.Size(553, 374);
            this.dataGridViewClass.TabIndex = 34;
            this.dataGridViewClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellClick);
            this.dataGridViewClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellContentClick);
            // 
            // DeleteClassAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 481);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.comboBoxClassAssign);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DeleteClassAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Class Assign";
            this.Load += new System.EventHandler(this.EditClassAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClassAssign;
        private System.Windows.Forms.DataGridView dataGridViewClass;
    }
}