using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Overloading_Indexers
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    class Company
    {
        private List<Employee> listEmployees;
        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee { EmployeeID = 1, Name = "Mike1", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeID = 2, Name = "Mike2", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeID = 3, Name = "Mike3", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeID = 4, Name = "Mike4", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeID = 5, Name = "Mike5", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeID = 6, Name = "Mike6", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeID = 7, Name = "Mike6", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeID = 8, Name = "Mike7", Gender = "Male" });
        }
        public string this[int employeeId]
        {
            get
            {
                /*from the list of employee return the first or Defualt entry emp such that (=>) that employeeId (emp.Employee)
                 * should match whatever (==) we pass into this indexer (employeeId)  to return an employee object. From that object pickup their
                 name and give me name*/
                return listEmployees.FirstOrDefault(emp => emp.EmployeeID == employeeId).Name;
            }
            set
            {
                listEmployees.First(emp => emp.EmployeeID == employeeId).Name = value; ;
            }
        }
        public string this[string Gender]
        {
            get
            {
                /*from the list of employee return the first or Defualt entry emp such that (=>) that employeeId (emp.Employee)
                 * should match whatever (==) we pass into this indexer (employeeId)  to return an employee object. From that object pickup their
                 name and give me name*/
                return listEmployees.Count(emp => emp.Gender == Gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.Gender == Gender) { employee.Gender = value; }
                }
            }
        }
    }
}
