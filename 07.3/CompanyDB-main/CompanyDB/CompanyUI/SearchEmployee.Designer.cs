
namespace CompanyUI
{
    partial class SearchEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEmployee));
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.HomeTitleLabel = new System.Windows.Forms.Label();
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
            this.EmployeeListBox.Location = new System.Drawing.Point(12, 68);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.EmployeeListBox.Size = new System.Drawing.Size(584, 522);
            this.EmployeeListBox.TabIndex = 2;
            // 
            // HomeTitleLabel
            // 
            this.HomeTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeTitleLabel.AutoSize = true;
            this.HomeTitleLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitleLabel.Location = new System.Drawing.Point(202, 9);
            this.HomeTitleLabel.Name = "HomeTitleLabel";
            this.HomeTitleLabel.Size = new System.Drawing.Size(182, 45);
            this.HomeTitleLabel.TabIndex = 3;
            this.HomeTitleLabel.Text = "Employees";
            this.HomeTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(608, 601);
            this.Controls.Add(this.HomeTitleLabel);
            this.Controls.Add(this.EmployeeListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "SearchEmployee";
            this.Text = "Search Employee";
            this.Load += new System.EventHandler(this.SearchEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label HomeTitleLabel;
    }
}