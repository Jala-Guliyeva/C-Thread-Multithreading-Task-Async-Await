using System;
using System.Collections;
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
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);

        }
        public IEnumerable GetEnumerator()
        {
            foreach (var employee in _employees)
            {
                yield return employee;
            }
        }
        public Employee this[int index]
        { get { return _employees[index]; } 
         set { _employees[index] = value; } }


       

    }
}
