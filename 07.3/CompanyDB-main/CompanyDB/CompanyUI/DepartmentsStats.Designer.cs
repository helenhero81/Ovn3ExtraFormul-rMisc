
namespace CompanyUI
{
    partial class DepartmentsStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsStats));
            this.DepInfoTitleLabel = new System.Windows.Forms.Label();
            this.DepInfoTabelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TotalSalaryLabel = new System.Windows.Forms.Label();
            this.TotalDepLabel = new System.Windows.Forms.Label();
            this.TotalDepVarLabel = new System.Windows.Forms.Label();
            this.TotalSalariesVarLabel = new System.Windows.Forms.Label();
            this.DepInfoDoneButton = new System.Windows.Forms.Button();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.SalaryListBox = new System.Windows.Forms.ListBox();
            this.DepInfoTabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepInfoTitleLabel
            // 
            this.DepInfoTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepInfoTitleLabel.AutoSize = true;
            this.DepInfoTitleLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepInfoTitleLabel.Location = new System.Drawing.Point(230, 9);
            this.DepInfoTitleLabel.Name = "DepInfoTitleLabel";
            this.DepInfoTitleLabel.Size = new System.Drawing.Size(190, 39);
            this.DepInfoTitleLabel.TabIndex = 3;
            this.DepInfoTitleLabel.Text = "Departments";
            this.DepInfoTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepInfoTabelPanel
            // 
            this.DepInfoTabelPanel.ColumnCount = 2;
            this.DepInfoTabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.2069F));
            this.DepInfoTabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.7931F));
            this.DepInfoTabelPanel.Controls.Add(this.TotalSalaryLabel, 0, 1);
            this.DepInfoTabelPanel.Controls.Add(this.TotalDepLabel, 0, 0);
            this.DepInfoTabelPanel.Controls.Add(this.TotalDepVarLabel, 1, 0);
            this.DepInfoTabelPanel.Controls.Add(this.TotalSalariesVarLabel, 1, 1);
            this.DepInfoTabelPanel.Location = new System.Drawing.Point(10, 51);
            this.DepInfoTabelPanel.Name = "DepInfoTabelPanel";
            this.DepInfoTabelPanel.RowCount = 2;
            this.DepInfoTabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DepInfoTabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DepInfoTabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DepInfoTabelPanel.Size = new System.Drawing.Size(630, 76);
            this.DepInfoTabelPanel.TabIndex = 4;
            // 
            // TotalSalaryLabel
            // 
            this.TotalSalaryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalSalaryLabel.AutoSize = true;
            this.TotalSalaryLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalaryLabel.Location = new System.Drawing.Point(32, 40);
            this.TotalSalaryLabel.Name = "TotalSalaryLabel";
            this.TotalSalaryLabel.Size = new System.Drawing.Size(164, 33);
            this.TotalSalaryLabel.TabIndex = 5;
            this.TotalSalaryLabel.Text = "Total Salaries:";
            this.TotalSalaryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalDepLabel
            // 
            this.TotalDepLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalDepLabel.AutoSize = true;
            this.TotalDepLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDepLabel.Location = new System.Drawing.Point(31, 0);
            this.TotalDepLabel.Name = "TotalDepLabel";
            this.TotalDepLabel.Size = new System.Drawing.Size(166, 38);
            this.TotalDepLabel.TabIndex = 4;
            this.TotalDepLabel.Text = "Total Departments:";
            this.TotalDepLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalDepVarLabel
            // 
            this.TotalDepVarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalDepVarLabel.AutoSize = true;
            this.TotalDepVarLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDepVarLabel.Location = new System.Drawing.Point(408, 2);
            this.TotalDepVarLabel.Name = "TotalDepVarLabel";
            this.TotalDepVarLabel.Size = new System.Drawing.Size(41, 33);
            this.TotalDepVarLabel.TabIndex = 6;
            this.TotalDepVarLabel.Text = "<>";
            this.TotalDepVarLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalSalariesVarLabel
            // 
            this.TotalSalariesVarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalSalariesVarLabel.AutoSize = true;
            this.TotalSalariesVarLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalariesVarLabel.Location = new System.Drawing.Point(408, 40);
            this.TotalSalariesVarLabel.Name = "TotalSalariesVarLabel";
            this.TotalSalariesVarLabel.Size = new System.Drawing.Size(41, 33);
            this.TotalSalariesVarLabel.TabIndex = 7;
            this.TotalSalariesVarLabel.Text = "<>";
            this.TotalSalariesVarLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepInfoDoneButton
            // 
            this.DepInfoDoneButton.BackColor = System.Drawing.Color.White;
            this.DepInfoDoneButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DepInfoDoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepInfoDoneButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepInfoDoneButton.Location = new System.Drawing.Point(271, 577);
            this.DepInfoDoneButton.Name = "DepInfoDoneButton";
            this.DepInfoDoneButton.Size = new System.Drawing.Size(109, 35);
            this.DepInfoDoneButton.TabIndex = 10;
            this.DepInfoDoneButton.Text = "Done";
            this.DepInfoDoneButton.UseVisualStyleBackColor = false;
            this.DepInfoDoneButton.Click += new System.EventHandler(this.DepInfoDoneButton_Click);
            // 
            // NameListBox
            // 
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.ItemHeight = 40;
            this.NameListBox.Location = new System.Drawing.Point(12, 149);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.NameListBox.Size = new System.Drawing.Size(227, 404);
            this.NameListBox.TabIndex = 11;
            // 
            // SalaryListBox
            // 
            this.SalaryListBox.FormattingEnabled = true;
            this.SalaryListBox.ItemHeight = 40;
            this.SalaryListBox.Location = new System.Drawing.Point(245, 149);
            this.SalaryListBox.Name = "SalaryListBox";
            this.SalaryListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.SalaryListBox.Size = new System.Drawing.Size(397, 404);
            this.SalaryListBox.TabIndex = 12;
            // 
            // DepartmentsStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 621);
            this.Controls.Add(this.SalaryListBox);
            this.Controls.Add(this.NameListBox);
            this.Controls.Add(this.DepInfoDoneButton);
            this.Controls.Add(this.DepInfoTabelPanel);
            this.Controls.Add(this.DepInfoTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "DepartmentsStats";
            this.Text = "Departments Info";
            this.Load += new System.EventHandler(this.DepartmentsStats_Load);
            this.DepInfoTabelPanel.ResumeLayout(false);
            this.DepInfoTabelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DepInfoTitleLabel;
        private System.Windows.Forms.TableLayoutPanel DepInfoTabelPanel;
        private System.Windows.Forms.Label TotalDepLabel;
        private System.Windows.Forms.Label TotalSalaryLabel;
        private System.Windows.Forms.Label TotalDepVarLabel;
        private System.Windows.Forms.Label TotalSalariesVarLabel;
        private System.Windows.Forms.Button DepInfoDoneButton;
        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.ListBox SalaryListBox;
    }
}