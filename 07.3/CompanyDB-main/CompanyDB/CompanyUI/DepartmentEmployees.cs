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
    public partial class DepartmentEmployees : Form
    {
        public DepartmentEmployees()
        {
            InitializeComponent();
        }

        private void DepartmentEmployees_Load(object sender, EventArgs e)
        {
            // load departments by name in combo box
            DepartmentComboBox.DataSource = GlobalConnector.Departments.Select(x => x.Name).ToArray();

            // load emps in deps
            GlobalConnector.LoadEmployeesInDepartments();

            loadEmpoyeesToComboBox();
        }
        private void DepartmentComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadEmpoyeesToComboBox();
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Helpers
        private void loadEmpoyeesToComboBox()
        {
            // get dep from combo box by name from global list
            Department dep = GlobalConnector.Departments.Find(d => d.Name == DepartmentComboBox.SelectedItem.ToString());

            // get list of employees in said department &  place fullnames in listbox
            EmployeeListBox.DataSource = dep.Employees.Select(emp => emp.getFullName()).ToArray();
        }
        #endregion

    }
}
