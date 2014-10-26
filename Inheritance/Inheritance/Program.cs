using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*Move all the common code into base employee class, inheritance promotes reusability, errors and test, a child class can have only one parent class
     but we can always have multi level inheritance*/
    /*public class ParentClass {
     * parent class implementation
     }
     public class DerivedClass : ParentClass {
     * child class implementation
     }
     * public classA : DerivedClass {
     * }
     */
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "First FTE";
            FTE.LastName = "Last FTE";
            FTE.YearlySalary = 50000;
            FTE.PrintFullName();
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "First PTE";
            PTE.LastName = "Last PTE";
            PTE.HourlySalary = 10;
            PTE.PrintFullName();
        }
    }
    public class Employee
    {
        /*for state vaariables its not recommended to have access modifiers like public*/
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            System.Console.WriteLine("First Name: " + FirstName + " " + LastName);
        }
    }
    /*class name : parent name for inheretance*/
    public class FullTimeEmployee : Employee
    {
       public float YearlySalary;

    }
    public class PartTimeEmployee : Employee
    {
      public  float HourlySalary;

    }
    public class ParentClass
    {
        public ParentClass()
        {
            System.Console.WriteLine("Parent Class Empty Constructor");
        }
        public ParentClass(string message)
        {
            System.Console.WriteLine("Message: " + message);
        }
    }
    public class ChildClass : ParentClass
    {
        /*if we have want to call the constructors with method in parent class then we use base keyword likethis:*/
        public ChildClass() : base("Derived Class Controlling Parent Class")
        {
            System.Console.WriteLine("Child Class Constructor Called");
        }
    }
}
