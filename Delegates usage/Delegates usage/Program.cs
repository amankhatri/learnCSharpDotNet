using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Delegates_usage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(){ID = 101, Name = "Mary", Salary = 5000, Experience = 5});
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });
            Employee.PromoteEmployee(empList);
            System.Console.ReadLine();
        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.Experience >= 5)
                {
                    System.Console.WriteLine("Employee: " + emp.Name + "can be promoted");
                }
            }
        }
    }
}
