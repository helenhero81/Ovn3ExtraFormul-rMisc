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
    public partial class SearchEmployee : Form
    {
        public string SearchTerm { set; get; }
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {

            List<Employee> emps = getEmployees();
            string[] empNames = emps.Select(x => x.getFullName()).ToArray();
            EmployeeListBox.DataSource = empNames;
        }

        #region Helpers
        private List<Employee> getEmployees()
        {
            List<Employee> emps = new List<Employee>();

            if (SearchTerm.Any(char.IsDigit))
            {
                // another bueatiful one liner that gets all employees that has the ssn number in thier ssn string 
                emps = GlobalConnector.Employees.FindAll(z => z.SSN.ToString().Contains(SearchTerm));
            }
            else if (SearchTerm.Any(char.IsLetter))
            {
                emps = GlobalConnector.Employees.FindAll(z => z.FisrtName.Contains(SearchTerm));
                emps.AddRange(GlobalConnector.Employees.FindAll(z => z.LastName.Contains(SearchTerm)));
                emps.AddRange(GlobalConnector.Employees.FindAll(z => z.Address.Contains(SearchTerm)));
            }

            return emps;
        }
        #endregion
    }
}
