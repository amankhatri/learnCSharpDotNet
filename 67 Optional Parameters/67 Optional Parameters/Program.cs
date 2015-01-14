using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_Optional_Parameters
{
    class Program
    {
        /*There are four ways  that can be used to maje method parameters optional
         1) use parameter arrays
         2) Method overloading
         3) Specify parameter defaults
        4)  use optionalAttribute that is present in System.Runtime.interopServices namespace
         Please Note: A parameter array must be the last parameter in a formal parameter list. the following function will not complie.
         public static void AddNumbers(int firstNumber, params object[] restOfTheNumbers, int secondNumber){}*/
        static void Main(string[] args)
        {
            AddNumber(10, 20);
            AddNumber(10, 20, 30);
        }
        public static void AddNumber(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result = result + i;
                }
            }
            System.Console.WriteLine("Sum = " + result);
        }
    }
}
