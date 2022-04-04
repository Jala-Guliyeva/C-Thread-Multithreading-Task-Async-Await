using System;
using System.Collections.Generic;
using System.Text;

namespace _4._4._22.Models
{
    internal class Employee
    {
        public int Id { get;  }
        private static int _id;
        public string  Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;

           
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} - Name:{Name} - Salary:{Salary}");
        }
    }
}
