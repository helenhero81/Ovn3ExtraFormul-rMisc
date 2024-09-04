using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyLib;

namespace CompanyUI
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void AddNewDepartmentSubmitButton_Click(object sender, EventArgs e)
        {
            // check user input validity
            if(!ValidForm())
            {
                string msg = "-Department Name should only contain Characters." + "\n" + "-Department number should only contain digits." + "\n" + "-No value should be left empty.";
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // check if there is a database
            else if (GlobalConnector.DepartmentFilePath == null)
            {
                string msg = "Must Initialize Database before creating any entries:\n- Home page > Edit > Connect Department Database";
                MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // create department object with valid form data
                Department department = new Department(int.Parse(DepartmentNumberTextBox.Text), DepartmentNameTextBox.Text, DepartmentAddressComboBox.Text);

                // ID and serialize all departments with new one amongst them
                GlobalConnector.SerializeDepartment(department);

                // clear out form fields
                DepartmentNameTextBox.Text = "";
                DepartmentNumberTextBox.Text = "";
                MessageBox.Show("Department Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        /// <summary>
        /// The method responsible for validating user input to the new Department Form
        /// </summary>
        /// <returns>Bool with true for valid and false for invalid form data</returns>
        private bool ValidForm()
        {

            if(DepartmentNameTextBox.Text.Length == 0 || DepartmentNumberTextBox.Text.Length == 0 || DepartmentAddressComboBox.Text.Length == 0)
            {
                return false;
            }

            #region Department Number Validation
            int departmentNumber;
            bool departmentNumberValid = int.TryParse(DepartmentNumberTextBox.Text, out departmentNumber);
            if(!departmentNumberValid)
            {
                return false;
            }
            else if(departmentNumber < 1)
            {
                return false;
            }
            #endregion

            #region Department Name Validation
            // check if department name contains any digits
            if(DepartmentNameTextBox.Text.Any(char.IsDigit))
            {
                return false;
            }
            #endregion

            return true;
        }

    }
}
