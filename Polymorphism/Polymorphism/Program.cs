using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /*Overriding methods, Poly morphism allows you to invoke derived class methods 
         from base class objects  or base class reference during run time. In base class method is declared as virtual and method in derived class
     is declared as overriding.*/
    class Program
    {
        static void Main(string[] args)
        {
            /*since all the emplooyes are of type Employee (parent) we would have to use over ride key word for all the methods in derived class and use
             virtual key word for the method in parent class*/
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemperoryEmployee();
            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
            System.Console.ReadLine();
        }
    }
    public class Employee
    {
        /*for state variables its not recommended to have access modifiers like public. Poly morphism allows you to invoke derived class methods 
         from base class objects*/
        public string FirstName = "First Name";
        public string LastName = "Last Name";
        public string Email;
        public virtual void PrintFullName()
        {
            System.Console.WriteLine("First Name: " + FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            System.Console.WriteLine("First Name: " + FirstName + " " + LastName + " " + "PartTime");
        }

    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            System.Console.WriteLine("First Name: " + FirstName + " " + LastName + " " + "FullTime");
        }


    }
    public class TemperoryEmployee : Employee
    {
  /*if i don't declare printFullName method for this class, all the objects of this class will use parent's printfullname.*/

    }
}
