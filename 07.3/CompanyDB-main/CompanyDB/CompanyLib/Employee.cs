using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLib
{
    /// <summary>
    /// Represents the employee that is a part of the epartment
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public String FisrtName { get; set; }
        public String LastName { get; set; }
        public char Minit { get; set; }
        public long SSN { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public char Sex { get; set; }
        public double Salary { get; set; }
        public int DepartmentNumber { get; set; }

        public Employee(){}

        public Employee(string firstName, string lastName, char minit, long ssn, DateTime birthday, string address, char sex, double salary, int depNumber)
        {
            this.FisrtName = firstName;
            this.LastName = lastName;
            this.Minit = minit;
            this.SSN = ssn;
            this.Birthday = birthday;
            this.Address = address;
            this.Sex = sex;
            this.Salary = salary;
            this.DepartmentNumber = depNumber;
        }

        public string getFullName()
        {
            return FisrtName + " " + LastName;
        }

    }

}
