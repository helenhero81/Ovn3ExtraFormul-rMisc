
namespace CompanyUI
{
    partial class SingleEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleEmployeeForm));
            this.FirstEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MinitComboBox = new System.Windows.Forms.ComboBox();
            this.sexLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SexRadioButtonF = new System.Windows.Forms.RadioButton();
            this.SexRadioButtonM = new System.Windows.Forms.RadioButton();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.MinitLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeBirthdaydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.FindEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.NextEmployeeButton = new System.Windows.Forms.Button();
            this.PreviousEmployeeButton = new System.Windows.Forms.Button();
            this.LastEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeLayoutPanel.SuspendLayout();
            this.sexLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstEmployeeButton
            // 
            this.FirstEmployeeButton.BackColor = System.Drawing.Color.White;
            this.FirstEmployeeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FirstEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstEmployeeButton.Location = new System.Drawing.Point(167, 511);
            this.FirstEmployeeButton.Name = "FirstEmployeeButton";
            this.FirstEmployeeButton.Size = new System.Drawing.Size(155, 49);
            this.FirstEmployeeButton.TabIndex = 5;
            this.FirstEmployeeButton.Text = "First Employee";
            this.FirstEmployeeButton.UseVisualStyleBackColor = false;
            this.FirstEmployeeButton.Click += new System.EventHandler(this.FirstEmployeeButton_Click);
            // 
            // AddEmployeeLayoutPanel
            // 
            this.AddEmployeeLayoutPanel.ColumnCount = 4;
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87129F));
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.63366F));
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30143F));
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.19362F));
            this.AddEmployeeLayoutPanel.Controls.Add(this.MinitComboBox, 3, 3);
            this.AddEmployeeLayoutPanel.Controls.Add(this.sexLayoutPanel, 1, 2);
            this.AddEmployeeLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.LastNameLabel, 0, 1);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SexLabel, 0, 2);
            this.AddEmployeeLayoutPanel.Controls.Add(this.BirthdayLabel, 0, 3);
            this.AddEmployeeLayoutPanel.Controls.Add(this.AddressLabel, 0, 4);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SSNLabel, 2, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.DepartmentLabel, 2, 1);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SalaryLabel, 2, 2);
            this.AddEmployeeLayoutPanel.Controls.Add(this.MinitLabel, 2, 3);
            this.AddEmployeeLayoutPanel.Controls.Add(this.FirstNameTextBox, 1, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.LastNameTextBox, 1, 1);
            this.AddEmployeeLayoutPanel.Controls.Add(this.AddressTextBox, 1, 4);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SSNTextBox, 3, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SalaryTextBox, 3, 2);
            this.AddEmployeeLayoutPanel.Controls.Add(this.EmployeeBirthdaydateTimePicker, 1, 3);
            this.AddEmployeeLayoutPanel.Controls.Add(this.DepartmentComboBox, 3, 1);
            this.AddEmployeeLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeLayoutPanel.Location = new System.Drawing.Point(25, 80);
            this.AddEmployeeLayoutPanel.Name = "AddEmployeeLayoutPanel";
            this.AddEmployeeLayoutPanel.RowCount = 5;
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.Size = new System.Drawing.Size(909, 389);
            this.AddEmployeeLayoutPanel.TabIndex = 4;
            // 
            // MinitComboBox
            // 
            this.MinitComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinitComboBox.FormattingEnabled = true;
            this.MinitComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.MinitComboBox.Location = new System.Drawing.Point(581, 259);
            this.MinitComboBox.Name = "MinitComboBox";
            this.MinitComboBox.Size = new System.Drawing.Size(325, 38);
            this.MinitComboBox.TabIndex = 16;
            // 
            // sexLayoutPanel
            // 
            this.sexLayoutPanel.ColumnCount = 2;
            this.sexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sexLayoutPanel.Controls.Add(this.SexRadioButtonF, 1, 0);
            this.sexLayoutPanel.Controls.Add(this.SexRadioButtonM, 0, 0);
            this.sexLayoutPanel.Location = new System.Drawing.Point(120, 157);
            this.sexLayoutPanel.Name = "sexLayoutPanel";
            this.sexLayoutPanel.RowCount = 1;
            this.sexLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sexLayoutPanel.Size = new System.Drawing.Size(326, 71);
            this.sexLayoutPanel.TabIndex = 2;
            // 
            // SexRadioButtonF
            // 
            this.SexRadioButtonF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SexRadioButtonF.AutoSize = true;
            this.SexRadioButtonF.Location = new System.Drawing.Point(223, 18);
            this.SexRadioButtonF.Name = "SexRadioButtonF";
            this.SexRadioButtonF.Size = new System.Drawing.Size(42, 34);
            this.SexRadioButtonF.TabIndex = 15;
            this.SexRadioButtonF.TabStop = true;
            this.SexRadioButtonF.Text = "F";
            this.SexRadioButtonF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SexRadioButtonF.UseVisualStyleBackColor = true;
            // 
            // SexRadioButtonM
            // 
            this.SexRadioButtonM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SexRadioButtonM.AutoSize = true;
            this.SexRadioButtonM.Location = new System.Drawing.Point(56, 18);
            this.SexRadioButtonM.Name = "SexRadioButtonM";
            this.SexRadioButtonM.Size = new System.Drawing.Size(51, 34);
            this.SexRadioButtonM.TabIndex = 14;
            this.SexRadioButtonM.TabStop = true;
            this.SexRadioButtonM.Text = "M";
            this.SexRadioButtonM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SexRadioButtonM.UseVisualStyleBackColor = true;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(111, 77);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name : ";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(3, 77);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(111, 77);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name : ";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SexLabel
            // 
            this.SexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.Location = new System.Drawing.Point(3, 154);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(111, 77);
            this.SexLabel.TabIndex = 2;
            this.SexLabel.Text = "Sex : ";
            this.SexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayLabel.Location = new System.Drawing.Point(3, 231);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(111, 77);
            this.BirthdayLabel.TabIndex = 3;
            this.BirthdayLabel.Text = "Birthday : ";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(3, 308);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(111, 81);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address : ";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSNLabel
            // 
            this.SSNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNLabel.Location = new System.Drawing.Point(452, 0);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(123, 77);
            this.SSNLabel.TabIndex = 5;
            this.SSNLabel.Text = "SSN :";
            this.SSNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.Location = new System.Drawing.Point(452, 77);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(123, 77);
            this.DepartmentLabel.TabIndex = 6;
            this.DepartmentLabel.Text = "Department :";
            this.DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryLabel.Location = new System.Drawing.Point(452, 154);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(123, 77);
            this.SalaryLabel.TabIndex = 7;
            this.SalaryLabel.Text = "Salary :";
            this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinitLabel
            // 
            this.MinitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinitLabel.AutoSize = true;
            this.MinitLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinitLabel.Location = new System.Drawing.Point(452, 231);
            this.MinitLabel.Name = "MinitLabel";
            this.MinitLabel.Size = new System.Drawing.Size(123, 77);
            this.MinitLabel.TabIndex = 8;
            this.MinitLabel.Text = "Minit :";
            this.MinitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Location = new System.Drawing.Point(120, 20);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(326, 36);
            this.FirstNameTextBox.TabIndex = 9;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Location = new System.Drawing.Point(120, 97);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(326, 36);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTextBox.Location = new System.Drawing.Point(120, 330);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(326, 36);
            this.AddressTextBox.TabIndex = 11;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SSNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSNTextBox.Location = new System.Drawing.Point(581, 20);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(325, 36);
            this.SSNTextBox.TabIndex = 12;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryTextBox.Location = new System.Drawing.Point(581, 174);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(325, 36);
            this.SalaryTextBox.TabIndex = 13;
            // 
            // EmployeeBirthdaydateTimePicker
            // 
            this.EmployeeBirthdaydateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeBirthdaydateTimePicker.Location = new System.Drawing.Point(120, 251);
            this.EmployeeBirthdaydateTimePicker.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.EmployeeBirthdaydateTimePicker.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.EmployeeBirthdaydateTimePicker.Name = "EmployeeBirthdaydateTimePicker";
            this.EmployeeBirthdaydateTimePicker.Size = new System.Drawing.Size(326, 36);
            this.EmployeeBirthdaydateTimePicker.TabIndex = 14;
            this.EmployeeBirthdaydateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(581, 105);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(325, 38);
            this.DepartmentComboBox.TabIndex = 15;
            // 
            // FindEmployeeTitleLabel
            // 
            this.FindEmployeeTitleLabel.AutoSize = true;
            this.FindEmployeeTitleLabel.Location = new System.Drawing.Point(377, 16);
            this.FindEmployeeTitleLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.FindEmployeeTitleLabel.Name = "FindEmployeeTitleLabel";
            this.FindEmployeeTitleLabel.Size = new System.Drawing.Size(204, 40);
            this.FindEmployeeTitleLabel.TabIndex = 3;
            this.FindEmployeeTitleLabel.Text = "Find Employee";
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.BackColor = System.Drawing.Color.White;
            this.UpdateEmployeeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UpdateEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(431, 511);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(97, 49);
            this.UpdateEmployeeButton.TabIndex = 6;
            this.UpdateEmployeeButton.Text = "Update";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = false;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // NextEmployeeButton
            // 
            this.NextEmployeeButton.BackColor = System.Drawing.Color.White;
            this.NextEmployeeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NextEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextEmployeeButton.Location = new System.Drawing.Point(534, 511);
            this.NextEmployeeButton.Name = "NextEmployeeButton";
            this.NextEmployeeButton.Size = new System.Drawing.Size(97, 49);
            this.NextEmployeeButton.TabIndex = 7;
            this.NextEmployeeButton.Text = "Next";
            this.NextEmployeeButton.UseVisualStyleBackColor = false;
            this.NextEmployeeButton.Click += new System.EventHandler(this.NextEmployeeButton_Click);
            // 
            // PreviousEmployeeButton
            // 
            this.PreviousEmployeeButton.BackColor = System.Drawing.Color.White;
            this.PreviousEmployeeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PreviousEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousEmployeeButton.Location = new System.Drawing.Point(328, 511);
            this.PreviousEmployeeButton.Name = "PreviousEmployeeButton";
            this.PreviousEmployeeButton.Size = new System.Drawing.Size(97, 49);
            this.PreviousEmployeeButton.TabIndex = 8;
            this.PreviousEmployeeButton.Text = "Previous";
            this.PreviousEmployeeButton.UseVisualStyleBackColor = false;
            this.PreviousEmployeeButton.Click += new System.EventHandler(this.PreviousEmployeeButton_Click);
            // 
            // LastEmployeeButton
            // 
            this.LastEmployeeButton.BackColor = System.Drawing.Color.White;
            this.LastEmployeeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LastEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastEmployeeButton.Location = new System.Drawing.Point(637, 511);
            this.LastEmployeeButton.Name = "LastEmployeeButton";
            this.LastEmployeeButton.Size = new System.Drawing.Size(155, 49);
            this.LastEmployeeButton.TabIndex = 9;
            this.LastEmployeeButton.Text = "Last Employee";
            this.LastEmployeeButton.UseVisualStyleBackColor = false;
            this.LastEmployeeButton.Click += new System.EventHandler(this.LastEmployeeButton_Click);
            // 
            // SingleEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 602);
            this.Controls.Add(this.LastEmployeeButton);
            this.Controls.Add(this.PreviousEmployeeButton);
            this.Controls.Add(this.NextEmployeeButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.FirstEmployeeButton);
            this.Controls.Add(this.AddEmployeeLayoutPanel);
            this.Controls.Add(this.FindEmployeeTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "SingleEmployeeForm";
            this.Text = "Find Employee";
            this.Load += new System.EventHandler(this.SingleEmployeeForm_Load);
            this.AddEmployeeLayoutPanel.ResumeLayout(false);
            this.AddEmployeeLayoutPanel.PerformLayout();
            this.sexLayoutPanel.ResumeLayout(false);
            this.sexLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstEmployeeButton;
        private System.Windows.Forms.TableLayoutPanel AddEmployeeLayoutPanel;
        private System.Windows.Forms.ComboBox MinitComboBox;
        private System.Windows.Forms.TableLayoutPanel sexLayoutPanel;
        private System.Windows.Forms.RadioButton SexRadioButtonF;
        private System.Windows.Forms.RadioButton SexRadioButtonM;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label MinitLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.DateTimePicker EmployeeBirthdaydateTimePicker;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.Label FindEmployeeTitleLabel;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button NextEmployeeButton;
        private System.Windows.Forms.Button PreviousEmployeeButton;
        private System.Windows.Forms.Button LastEmployeeButton;
    }
}