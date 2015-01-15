using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Making_Method_Parameters_options
{
    class Program
    {
        /*using method overloading to make method parameters optional*/
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
            Test(1, 2);
        }
       
        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result = result + i;
                }
            }
            System.Console.WriteLine("Sum " + result);
        }
       //specifying default values to make parameters optionals
        public static void Test(int a, int b=10, int c =20)
        {
            System.Console.WriteLine("a = " + a);
            System.Console.WriteLine("b = " + b);
            System.Console.WriteLine("c = " + c);
        }
    }
}
