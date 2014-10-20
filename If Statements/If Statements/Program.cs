using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please Enter a Number");
            /*Parsing in case if the input is not an int*/
            int userInput = int.Parse(System.Console.ReadLine());
            if (userInput == 1)
            {
                System.Console.WriteLine("Number is One");
            }
            else if (userInput == 2)
            {
                System.Console.WriteLine("Number is two");
            }
            /*|| double pipe means it will check only one condition in the following 
            expression: */
            else if (userInput == 2 || userInput == 3)
            {
                System.Console.WriteLine("Number is double piped");
            }
            /*| single pipe means it will check both the condition in the following 
            expression: */
            else if (userInput == 2 || userInput == 3)
            {
                System.Console.WriteLine("Number is single piped");
            }
            /*&& double means it will check only one condition in the following 
            expression: */
            else if (userInput == 2 && userInput == 3)
            {
                System.Console.WriteLine("Number is double amppercet");
            }
            /*& single ampresent means it will check both the condition in the following 
            expression: */
            else if (userInput == 2 && userInput == 3)
            {
                System.Console.WriteLine("Number is single piped");
            }		

        }
    }
}
