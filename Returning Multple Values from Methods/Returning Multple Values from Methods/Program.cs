using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returning_Multple_Values_from_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int product = 0;
            calculate(10, 20, out total, out product);
            System.Console.WriteLine("Sum: {0} ", total);
            System.Console.WriteLine("Product: {0} ", product);
            
        }
        public static void calculate(int firstNumber, int secondNumber, out int sum, out int product){
            sum = firstNumber + secondNumber;
            product = firstNumber * secondNumber;
        }
    }
}
