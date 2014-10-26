using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    /*we will learn about method hiding and invoking hidden methods*/
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "First FTE";
            FTE.LastName = "Last FTE";
            FTE.PrintFullName();
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "First PTE";
            PTE.LastName = "Last PTE";
            PTE.PrintFullName();
            /*you can convert a type child operator to a parent type  by doing this*/
            ((Employee)PTE).PrintFullName();
            /*Sincee a child class object can cover all the things from parent class we can allso do this:*/
            Employee PTE1 = new PartTimeEmployee();
            PTE1.FirstName = "First PTE";
            PTE1.LastName = "Last PTE";
            PTE1.PrintFullName();
            System.Console.ReadLine();
            /*Remember you can't do PartTimeEmployee PTE = new Employee(); because parents will not have all the features of the child class.*/
        }
    }
    public class Employee
    {
        public string FirstName;
        public string LastName;
        /*if i declare the printFullName() method in any of the child classes then this method in parent class would be hidden */
        public void PrintFullName()
        {
            System.Console.WriteLine("First Name: " + FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        /*This method will hide the inhereted PrintFullName()*/
        public new void PrintFullName()
        {
            System.Console.WriteLine("First Name: " + FirstName + " " + LastName + "--Contractor");
        }

    }
    public class FullTimeEmployee : Employee
    {
        /*if you want to call the printFull name from the parent class then you do this:*/
        public new void PrintFullName()
        {
            base.PrintFullName();
        }
    }
}
