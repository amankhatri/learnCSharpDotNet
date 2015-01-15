using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace _70_Using_optionalparameters
{
    class Program
    {
        /*optional parameter using optionalAttribute*/
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
        }
        /*optional parameter using optionalAttribute*/
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers = null)
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
   
       
    }
}
