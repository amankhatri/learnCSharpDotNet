using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numerator = 10;
            int Denominator = 2;
            int quotient = Numerator / Denominator;
            int remainder = Numerator % Denominator;
            System.Console.WriteLine("/" + quotient);
            System.Console.WriteLine("/" + remainder);
            /*All the conditional statements are same as for java . Look at this cool thing*/
            bool IsNumber10;
            int Number = 10;
            if (Number == 10)
            {
                IsNumber10 = true;
            }
            else
            {
                IsNumber10 = false;
            }
            System.Console.WriteLine("Number == 10 is {0}", IsNumber10);
            /*fancy way of boolean implementation using ternary operator*/
            int Number2 =15;
            bool IsNumber15 = Number2 == 10 ? true : false;
            System.Console.WriteLine("IsNumber15 " + IsNumber15);



        }
    }
}
