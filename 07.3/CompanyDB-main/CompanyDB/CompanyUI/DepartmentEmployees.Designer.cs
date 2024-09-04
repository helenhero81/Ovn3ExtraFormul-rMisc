
namespace CompanyUI
{
    partial class DepartmentEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentEmployees));
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 40;
            this.EmployeeListBox.Location = new System.Drawing.Point(12, 135);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.EmployeeListBox.Size = new System.Drawing.Size(477, 402);
            this.EmployeeListBox.TabIndex = 2;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(12, 81);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(477, 48);
            this.DepartmentComboBox.TabIndex = 16;
            this.DepartmentComboBox.SelectionChangeCommitted += new System.EventHandler(this.DepartmentComboBox_SelectionChangeCommitted);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.White;
            this.DoneButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(199, 554);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(103, 35);
            this.DoneButton.TabIndex = 17;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(119, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(262, 40);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "Department Search";
            // 
            // DepartmentEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 611);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.EmployeeListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "DepartmentEmployees";
            this.Text = "Department Employees";
            this.Load += new System.EventHandler(this.DepartmentEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}