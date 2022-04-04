using System;
using System.Collections.Generic;
using System.Text;

namespace _4._4._22.Models
{
    internal class Department
    {
        public int Id { get;  }
        private static int _id;
        public string Name { get; set; }
        private List<Employee> _employees;

        public Department()
        {
            _id++;
            Id = _id;
            _employees=new List<Employee>();
        }
        public void AddEmployee()
        {
            _employees.Add(new Employee());

        }


       

    }
}
