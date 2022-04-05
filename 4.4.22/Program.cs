using _4._4._22.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace _4._4._22
{
    internal class Program
    {
        
        public int Count { get; set; }
        static void Main(string[] args)
        {

            Employee employee = new Employee()
            {
                Name ="Jale",
                Salary =120
            };

            Department department = new Department();
            department.AddEmployee(employee);

           
            department[0].ShowInfo();









       }     
    }
}
