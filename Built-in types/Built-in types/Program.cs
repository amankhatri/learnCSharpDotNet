using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean boolean;
            int integerNumber;
            float floatNumber;
            double doubleNumber;
            char character;
            String stringStatement;
            String stringStatement1;
            String stringStatement2;
            System.Console.WriteLine("Minimum Integer Value: " + int.MinValue);
            System.Console.WriteLine("Maximum Integer Value: " + int.MaxValue);
            stringStatement = "Some Name";
            System.Console.WriteLine("Name: {0}", stringStatement);
            /*We also have verbatum is whatever you type so */
            System.Console.WriteLine("Without using Verbatum Symbol @");
            stringStatement1 = "C:\\Program Files (x86)";
            System.Console.WriteLine("stringStatement1: " + stringStatement1);
            System.Console.WriteLine("Using Verbatum Symbol we won't have to use escape char. ");
            stringStatement2 = @"C:\Program Files (x86)";
            System.Console.WriteLine("stringStatement2: " + stringStatement2);
        }
    }
}
