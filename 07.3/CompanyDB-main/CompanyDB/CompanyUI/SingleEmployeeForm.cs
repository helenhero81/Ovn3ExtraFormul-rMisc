using CompanyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyUI
{
    public partial class SingleEmployeeForm : Form
    {
        private Employee currentEmployee;
        private Employee lastEmployee;

        public SingleEmployeeForm()
        {
            InitializeComponent();
        }

        private void SingleEmployeeForm_Load(object sender, EventArgs e)
        {
            // load first employee
            currentEmployee = getEmployee(1);

            lastEmployee = GlobalConnector.Employees.Last();

            // load departments in department comb box
            int[] departmentsNumbers = GlobalConnector.Departments.Select(x => x.Number).ToArray(); 
            DepartmentComboBox.DataSource = departmentsNumbers;

            loadEmpToUi(currentEmployee);
        }

        #region Buttons
        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            // validate info from boxes
            if (!ValidForm())
            {
                invalideError();
            }
            else
            {
                // update current employee obj
                Employee tempEmp = updateEmployee(currentEmployee);
                currentEmployee = tempEmp;

                // get index of current employee in global list
                Employee oldEmployee = GlobalConnector.Employees.First(x => x.Id == currentEmployee.Id);
                int index = GlobalConnector.Employees.IndexOf(oldEmployee);

                // place back the object in global list
                GlobalConnector.Employees[index] = currentEmployee;

                // write list again to disk
                GlobalConnector.SerializeEmployee(currentEmployee);


                MessageBox.Show("Updated Employee Succesfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void NextEmployeeButton_Click(object sender, EventArgs e)
        {
            if(currentEmployee.Id != lastEmployee.Id)
            {
                Employee emp = GlobalConnector.Employees.First(i => i.Id == currentEmployee.Id + 1);
                currentEmployee = emp;
                loadEmpToUi(emp);
            }
        }
        private void PreviousEmployeeButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee.Id != 1)
            {
                Employee emp = GlobalConnector.Employees.First(i => i.Id == currentEmployee.Id - 1);
                currentEmployee = emp;
                loadEmpToUi(emp);
            }
        }
        private void LastEmployeeButton_Click(object sender, EventArgs e)
        {
            loadEmpToUi(lastEmployee);
            currentEmployee = lastEmployee;
        }
        private void FirstEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee emp = getEmployee(1);
            loadEmpToUi(emp);
            currentEmployee = emp;
        }
        #endregion

        #region Private helpers
        private bool ValidForm()
        {
            if (FirstNameTextBox.Text.Length == 0 || LastNameTextBox.Text.Length == 0
                || AddressTextBox.Text.Length == 0 || SSNTextBox.Text.Length == 0
                || DepartmentComboBox.Text.Length == 0 || SalaryTextBox.Text.Length == 0
                || MinitComboBox.Text.Length == 0)
            {
                return false;
            }

            if (FirstNameTextBox.Text.Any(char.IsDigit))
            {
                return false;
            }

            if (LastNameTextBox.Text.Any(char.IsDigit))
            {
                return false;
            }

            if (SSNTextBox.Text.Any(char.IsLetter) || SSNTextBox.Text.Length != 9)
            {
                return false;
            }

            if (SalaryTextBox.Text.Any(char.IsLetter))
            {
                return false;
            }

            //check for future dates or dates closer than 18 year

            return true;
        }
        private void invalideError()
        {
            string msg = "- Employee first and last names should only contain Characters." + "\n" + "- Employee SSN should be 9 digits only";
            msg = msg + "\n" + "- Employee Salary should be digits only" + "\n" + "- Emlpoyee Birthday should not be in the future or ower than 18 year from now";
            msg = msg + "\n" + "- No value should be left empty.";
            MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private Employee getEmployee(int id)
        {
            return GlobalConnector.Employees.Find(e => e.Id == id);
        }
        private void loadEmpToUi(Employee emp)
        {
            FirstNameTextBox.Text = emp.FisrtName;
            LastNameTextBox.Text = emp.LastName;
            if (emp.Sex == 'M')
            {
                SexRadioButtonM.Checked = true;
            }
            else
            {
                SexRadioButtonF.Checked = true;
            }
            EmployeeBirthdaydateTimePicker.Value = emp.Birthday;
            AddressTextBox.Text = emp.Address;
            SSNTextBox.Text = emp.SSN.ToString();
            DepartmentComboBox.Text = emp.DepartmentNumber.ToString(); // here
            SalaryTextBox.Text = emp.Salary.ToString();
            MinitComboBox.Text = emp.Minit.ToString();
        }
        private Employee updateEmployee(Employee emp)
        {
            emp.FisrtName = FirstNameTextBox.Text;
            emp.LastName = LastNameTextBox.Text;
            emp.Address = AddressTextBox.Text;
            emp.Minit = char.Parse(MinitComboBox.Text);
            emp.SSN = long.Parse(SSNTextBox.Text);
            emp.Birthday = EmployeeBirthdaydateTimePicker.Value;
            // bueatiful one liner that gets the checked radio button value from parant panel
            emp.Sex = char.Parse(sexLayoutPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
            emp.Salary = double.Parse(SalaryTextBox.Text);
            emp.DepartmentNumber = int.Parse(DepartmentComboBox.Text);

            return emp;
        }
        #endregion

    }
}