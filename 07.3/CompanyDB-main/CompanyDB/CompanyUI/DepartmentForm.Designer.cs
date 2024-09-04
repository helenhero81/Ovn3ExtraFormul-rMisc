
namespace CompanyUI
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.addEmployeeSubmitButton = new System.Windows.Forms.Button();
            this.AddEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.AddDepartmentLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DepartmentNumberLabel = new System.Windows.Forms.Label();
            this.DepartmentAddressLabel = new System.Windows.Forms.Label();
            this.DepartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentNameLabel = new System.Windows.Forms.Label();
            this.DepartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentAddressComboBox = new System.Windows.Forms.ComboBox();
            this.AddNewDepartmentSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDepartmentLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeSubmitButton
            // 
            this.addEmployeeSubmitButton.BackColor = System.Drawing.Color.White;
            this.addEmployeeSubmitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addEmployeeSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeSubmitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeSubmitButton.Location = new System.Drawing.Point(472, 1172);
            this.addEmployeeSubmitButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.addEmployeeSubmitButton.Name = "addEmployeeSubmitButton";
            this.addEmployeeSubmitButton.Size = new System.Drawing.Size(533, 151);
            this.addEmployeeSubmitButton.TabIndex = 5;
            this.addEmployeeSubmitButton.Text = "Submit";
            this.addEmployeeSubmitButton.UseVisualStyleBackColor = false;
            // 
            // AddEmployeeTitleLabel
            // 
            this.AddEmployeeTitleLabel.AutoSize = true;
            this.AddEmployeeTitleLabel.Location = new System.Drawing.Point(792, -126);
            this.AddEmployeeTitleLabel.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.AddEmployeeTitleLabel.Name = "AddEmployeeTitleLabel";
            this.AddEmployeeTitleLabel.Size = new System.Drawing.Size(203, 40);
            this.AddEmployeeTitleLabel.TabIndex = 3;
            this.AddEmployeeTitleLabel.Text = "Add Employee";
            // 
            // AddDepartmentLayoutPanel
            // 
            this.AddDepartmentLayoutPanel.ColumnCount = 2;
            this.AddDepartmentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.00001F));
            this.AddDepartmentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.AddDepartmentLayoutPanel.Controls.Add(this.DepartmentNumberLabel, 0, 2);
            this.AddDepartmentLayoutPanel.Controls.Add(this.DepartmentAddressLabel, 0, 1);
            this.AddDepartmentLayoutPanel.Controls.Add(this.DepartmentNameTextBox, 1, 0);
            this.AddDepartmentLayoutPanel.Controls.Add(this.DepartmentNameLabel, 0, 0);
            this.AddDepartmentLayoutPanel.Controls.Add(this.DepartmentNumberTextBox, 1, 2);
            this.AddDepartmentLayoutPanel.Controls.Add(this.DepartmentAddressComboBox, 1, 1);
            this.AddDepartmentLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDepartmentLayoutPanel.Location = new System.Drawing.Point(17, 146);
            this.AddDepartmentLayoutPanel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.AddDepartmentLayoutPanel.Name = "AddDepartmentLayoutPanel";
            this.AddDepartmentLayoutPanel.RowCount = 3;
            this.AddDepartmentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AddDepartmentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AddDepartmentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AddDepartmentLayoutPanel.Size = new System.Drawing.Size(531, 161);
            this.AddDepartmentLayoutPanel.TabIndex = 7;
            // 
            // DepartmentNumberLabel
            // 
            this.DepartmentNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentNumberLabel.AutoSize = true;
            this.DepartmentNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentNumberLabel.Location = new System.Drawing.Point(8, 106);
            this.DepartmentNumberLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DepartmentNumberLabel.Name = "DepartmentNumberLabel";
            this.DepartmentNumberLabel.Size = new System.Drawing.Size(122, 55);
            this.DepartmentNumberLabel.TabIndex = 11;
            this.DepartmentNumberLabel.Text = "Number : ";
            this.DepartmentNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentAddressLabel
            // 
            this.DepartmentAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentAddressLabel.AutoSize = true;
            this.DepartmentAddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentAddressLabel.Location = new System.Drawing.Point(8, 53);
            this.DepartmentAddressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DepartmentAddressLabel.Name = "DepartmentAddressLabel";
            this.DepartmentAddressLabel.Size = new System.Drawing.Size(122, 53);
            this.DepartmentAddressLabel.TabIndex = 1;
            this.DepartmentAddressLabel.Text = "Address :";
            this.DepartmentAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentNameTextBox
            // 
            this.DepartmentNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartmentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartmentNameTextBox.Location = new System.Drawing.Point(146, 9);
            this.DepartmentNameTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            this.DepartmentNameTextBox.Size = new System.Drawing.Size(377, 36);
            this.DepartmentNameTextBox.TabIndex = 9;
            // 
            // DepartmentNameLabel
            // 
            this.DepartmentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentNameLabel.AutoSize = true;
            this.DepartmentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentNameLabel.Location = new System.Drawing.Point(8, 0);
            this.DepartmentNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DepartmentNameLabel.Name = "DepartmentNameLabel";
            this.DepartmentNameLabel.Size = new System.Drawing.Size(122, 53);
            this.DepartmentNameLabel.TabIndex = 0;
            this.DepartmentNameLabel.Text = "Name : ";
            this.DepartmentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentNumberTextBox
            // 
            this.DepartmentNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartmentNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartmentNumberTextBox.Location = new System.Drawing.Point(146, 115);
            this.DepartmentNumberTextBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DepartmentNumberTextBox.Name = "DepartmentNumberTextBox";
            this.DepartmentNumberTextBox.Size = new System.Drawing.Size(377, 36);
            this.DepartmentNumberTextBox.TabIndex = 12;
            // 
            // DepartmentAddressComboBox
            // 
            this.DepartmentAddressComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartmentAddressComboBox.FormattingEnabled = true;
            this.DepartmentAddressComboBox.Items.AddRange(new object[] {
            "Cairo",
            "Benha",
            "Alex"});
            this.DepartmentAddressComboBox.Location = new System.Drawing.Point(145, 60);
            this.DepartmentAddressComboBox.Name = "DepartmentAddressComboBox";
            this.DepartmentAddressComboBox.Size = new System.Drawing.Size(378, 38);
            this.DepartmentAddressComboBox.TabIndex = 13;
            // 
            // AddNewDepartmentSubmitButton
            // 
            this.AddNewDepartmentSubmitButton.BackColor = System.Drawing.Color.White;
            this.AddNewDepartmentSubmitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddNewDepartmentSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewDepartmentSubmitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewDepartmentSubmitButton.Location = new System.Drawing.Point(182, 384);
            this.AddNewDepartmentSubmitButton.Name = "AddNewDepartmentSubmitButton";
            this.AddNewDepartmentSubmitButton.Size = new System.Drawing.Size(200, 49);
            this.AddNewDepartmentSubmitButton.TabIndex = 8;
            this.AddNewDepartmentSubmitButton.Text = "Submit";
            this.AddNewDepartmentSubmitButton.UseVisualStyleBackColor = false;
            this.AddNewDepartmentSubmitButton.Click += new System.EventHandler(this.AddNewDepartmentSubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Department";
            // 
            // DepartmentForm
            // 
            this.AcceptButton = this.AddNewDepartmentSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNewDepartmentSubmitButton);
            this.Controls.Add(this.AddDepartmentLayoutPanel);
            this.Controls.Add(this.addEmployeeSubmitButton);
            this.Controls.Add(this.AddEmployeeTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "DepartmentForm";
            this.Text = "Add New Department";
            this.AddDepartmentLayoutPanel.ResumeLayout(false);
            this.AddDepartmentLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeSubmitButton;
        private System.Windows.Forms.Label AddEmployeeTitleLabel;
        private System.Windows.Forms.TableLayoutPanel AddDepartmentLayoutPanel;
        private System.Windows.Forms.Label DepartmentNameLabel;
        private System.Windows.Forms.Label DepartmentAddressLabel;
        private System.Windows.Forms.TextBox DepartmentNameTextBox;
        private System.Windows.Forms.Label DepartmentNumberLabel;
        private System.Windows.Forms.TextBox DepartmentNumberTextBox;
        private System.Windows.Forms.Button AddNewDepartmentSubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DepartmentAddressComboBox;
    }
}