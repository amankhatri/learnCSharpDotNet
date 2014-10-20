using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_and_For_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            int i = 0;
            while (i < numbers.Length)
            {
                System.Console.WriteLine(numbers[i]);
                i++;
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                System.Console.WriteLine(numbers[i]);
            }
            foreach (int value in numbers)
            {
                System.Console.WriteLine(value);
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                if (j % 2 == 1)
                {
                    /*after the program encounters this word it exits this if condiion and increments j and executes the for loop again*/
                    continue;
                }
                System.Console.WriteLine(numbers[j]);
            }

        }
    }
}
