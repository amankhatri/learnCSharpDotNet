using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Usage_2
{
    /*we have to make the logic of the promote employee method to be flexible, to do that we will use delgates. This is how we do it*/
    delegate bool IsPromotable(Employee emp1);
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });
            IsPromotable isPromotable1 = new IsPromotable(Promote);
            /* we can aslo achieve this using lambda expression*/
            Employee.PromoteEmployee(empList,isPromotable1);
            System.Console.ReadLine();
        }

        private static bool Promote(Employee emp1)
        {
            if(emp1.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  

        
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee emp in employeeList)
            {
                if (IsEligibleToPromote(emp))
                {
                    System.Console.WriteLine("Employee: " + emp.Name + "can be promoted");
                }
            }
        }
    }
}
