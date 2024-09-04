using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompanyLib
{
    /// <summary>
    /// The Connector class is responsible for connecting and handling of the database (in text files)
    /// and all Global information needed by the App
    /// </summary>
    public class GlobalConnector
    {
        #region Global
        /// <summary>
        /// Global variables that control global information needed accross App
        /// </summary>
        public static string DepartmentFilePath { get; set; }
        public static string EmployeeFilePath { get; set; }
        public static List<Department> Departments{ get; set;}
        public static List<Employee> Employees { get; set; }

        private static List<string> ConnectDBFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath).ToList();
            }
            else
            {
                return new List<string>();
            }
        }
        #endregion

        #region Department Serializers

        /// <summary>
        /// loads departemnt from file system to a global list of departments
        /// </summary>
        /// <param name="filePath">system file path to departments csv file</param>
        public static void LoadDepartments(string filePath)
        {
            List<string> lines = ConnectDBFile(filePath);

            List<Department> departments = new List<Department>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                departments.Add(new Department(int.Parse(cols[0]), int.Parse(cols[1]), cols[2], cols[3]));
            }

            GlobalConnector.Departments = departments;
        }
        public static void SerializeDepartment(Department dep)
        {
            // get max ID and add next one to current department
            int currID = 1;
            if(GlobalConnector.Departments == null)
            {
                GlobalConnector.Departments = new List<Department>();
            }
            else
            {
                if(GlobalConnector.Departments.Count > 0)
                {
                    currID = GlobalConnector.Departments.OrderByDescending(x => x.Id).First().Id + 1;
                }
            }

            dep.Id = currID;

            GlobalConnector.Departments.Add(dep);

            List<string> lines = new List<string>();

            // add each object the a list of string with comma seperated values
            foreach(Department d in GlobalConnector.Departments)
            {
                lines.Add($"{ d.Id },{ d.Number },{ d.Name },{ d.Address }");
            }

            // write DB to disk
            File.WriteAllLines(GlobalConnector.DepartmentFilePath, lines);
        }

        /// <summary>
        /// Loads employees in department's employee list property
        /// </summary>
        public static void LoadEmployeesInDepartments()
        {
            if(GlobalConnector.Departments == null || GlobalConnector.Employees == null)
            {
                throw new NullReferenceException("DB has no entries");
            }

            foreach(Department dep in GlobalConnector.Departments)
            {
                // one liner to get all employees from employee db with same number as each department
                List<Employee> empsInDep = GlobalConnector.Employees.FindAll(x => x.DepartmentNumber == dep.Number);

                foreach(Employee emp in empsInDep)
                {
                    // add said employees to employee list in said department if he is not already in list
                    if(!dep.Employees.Any(e => e.Id == emp.Id))
                    {
                        dep.Employees.Add(emp);
                    }
                }
            }
        }

        #endregion

        #region Employee Serializers
        public static void LoadEmployees(string filePath)
        {
            List<string> lines = ConnectDBFile(filePath);

            List<Employee> employees = new List<Employee>();

            // loading info from csv file to each employee property
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                Employee emp = new Employee();

                emp.Id = int.Parse(cols[0]);
                emp.FisrtName = cols[1];
                emp.LastName = cols[2];
                emp.Sex = char.Parse(cols[3]);
                emp.SSN = long.Parse(cols[4]);
                string[] bday = cols[5].Split('-'); // splits the bday string even more to allow usage of datetime object
                emp.Birthday = new DateTime(int.Parse(bday[0]), int.Parse(bday[1]), int.Parse(bday[2]));
                emp.Address = cols[6];
                emp.DepartmentNumber = int.Parse(cols[7]);
                emp.Salary = double.Parse(cols[8]);
                emp.Minit = char.Parse(cols[9]);

                employees.Add(emp);
            }

            GlobalConnector.Employees = employees;
        }
        public static void SerializeEmployee(Employee emp)
        {
            if(emp.Id == 0)
            {
                int CurrID = 1;
                if(GlobalConnector.Employees == null)
                {
                    GlobalConnector.Employees = new List<Employee>();
                }
                else
                {
                    if(GlobalConnector.Employees.Count > 0)
                    {
                        CurrID = GlobalConnector.Employees.OrderByDescending(x => x.Id).First().Id + 1;
                    }
                }

                emp.Id = CurrID;

                GlobalConnector.Employees.Add(emp);
            }

            List<string> lines = new List<string>();

            foreach(Employee e in GlobalConnector.Employees)
            {
                string bday = e.Birthday.Date.ToString("yyyy-MM-dd");
                lines.Add($"{e.Id},{e.FisrtName},{e.LastName},{e.Sex},{e.SSN},{bday},{e.Address},{e.DepartmentNumber},{e.Salary},{e.Minit}");
            }

            //write to disk
            File.WriteAllLines(GlobalConnector.EmployeeFilePath, lines);

        }
        #endregion
    }
}
