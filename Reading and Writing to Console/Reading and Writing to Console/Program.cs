
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_and_Writing_to_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*There are two ways to write something to console 1) Using Concetination and 2) Using Placeholders*/
            String firstName;
            String lastName;
            System.Console.WriteLine("Please enter your First name");
            firstName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your Last name");
            lastName = System.Console.ReadLine();
            /*This is method of printing the name is Concatination*/
            System.Console.WriteLine("Printing using Concatination. ");
            System.Console.WriteLine("Hello " + firstName + " "+lastName);
            /*This is method of printing the name is PlaceHolders {0} {1} are placeholders, This is preffered*/
            System.Console.WriteLine("Printing Using Placeholders. {0} {1} is a place holder");
            System.Console.WriteLine("Hello {0} {1} ", firstName,lastName);
            System.Console.ReadLine();
            
        }
    }
}
