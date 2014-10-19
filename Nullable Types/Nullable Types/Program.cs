using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*In C sharpt types are divided into 2 broad categories Value types and Reference Types
            1) Value Types - int, float, double, struct, enum etc
            2) Interface,Class,Delegates, arrays etc*/
            /*By default value types are non nullable. To make them nullable use ?
             int i =0 (i is not nullable, so i cannot be set to null, i = null will generate compuler error)
             int? j =0 (j is nullable int so j=null is legal)*/
            /*nullable types bridge the differences between c sharp types and database types*/
            /*Nullable if any field in a from is nullable  that means it can have null in it. 
             Suppose you have a form First Name: , Last Name: , Are you Major: . so Are you major is a optional question and 
             if user wants to leave it blank we should have a way to store null in a variable. Also in database you can store 
             null in databases. 
             * Nullables has three types of values associate with them True, False or nothing/Null */
            int? i = null;
            bool? AreYouMajor = null;
            if (AreYouMajor == true)
            {
                System.Console.WriteLine("User is Major");
            } /* AreYouMajor can also say*/
            else if (!AreYouMajor.Value)
            {
                System.Console.WriteLine("User is not Major");
            }
            else
            {
                System.Console.WriteLine("User did not answer the question");
            }
            /*Null Caleascing Operator*/
            int? ticketsOnSale = null; /*initially there are no tickets avaiable on sale*/
            int availableTickets;
            if (ticketsOnSale == null)
            {
                availableTickets = 0;
            }
            else
            {
               /* availableTickets = ticketsOnSale; gives you an error saying that you can't convert int? into int to do that you can use
                availableTickets = ticketsOnSale.Value or we can do a cast like this:*/
                availableTickets = (int)ticketsOnSale;
            }
            System.Console.WriteLine("Available Tickets " + availableTickets);

            /*or instead of writing the big if else if condition*/
            /*it says if ticketsOnSale is null then set avaiableTickets to 0 otherwise use the value which is insider the variable ticketsOnsale*/
            int availableTickets2 = ticketsOnSale ?? 0;


        }
    }
}
