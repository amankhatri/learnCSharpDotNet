using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Partial_Classes
{
    class Program
    {
        /*Partial Classes allow us to split a class into 2 or more files. All these parts are then combined into a single class, when the application
         is compiled. The partial keyword can also be used to split a struct or an interface over two or more file
         
         Advantages of partial classes.
         1) AThe main advantage is that, visual studio uses partial classes to seperate, automatically cenerated system code from the developer's code
         For example when you add a webform, two .cs files are generated.
         a) Webform1.aspx.cs- which contains the developer code
         b) Webform1.aspx.designer.cs - contains the system generated code. For example declaration for the controls that you drag and drop on the 
         webform
         2) when working on large projects, spreading a clss over separate files allows multiple programmers to work on it simultaneously. */
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = " Non Partial";
            c1.LastName = " Classes";
            string FullName = c1.GetFullName();
            System.Console.WriteLine("Full Name" + FullName);

            PartialCustomer PC1 = new PartialCustomer();
            PC1.FirstName = " Partial";
            PC1.LastName = " Customer";
            System.Console.WriteLine("Full Name" + PC1.GetFullName());
        }
    }
}
