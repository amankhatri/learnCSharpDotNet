using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_Making_Method_Parameters_optional
{
    class Program
    {
        /*using method overloading to make method parameters optional*/
        static void Main(string[] args)
        {
            AddNumbers(10, 20, new int[]{30,40});
        }
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }
        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if(restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result = result + i;
                }
            }
            System.Console.WriteLine("Sum " + result);
        }
    }
}
