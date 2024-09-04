using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLib
{
    public class Department
    {
        /// <summary>
        /// Represents a company department that has employees
        /// </summary>
        public string Name { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Department(){}

        public Department(int number, string name, string address){
            this.Name = name;
            this.Address = address;
            this.Number = number;
        }
        public Department(int id, int number, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Number = number;
        }

    }
}
