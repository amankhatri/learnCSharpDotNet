using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a Number");
		    int userInput = int.Parse(System.Console.ReadLine());
		    switch(userInput){
			    case 10:
				    System.Console.WriteLine("Your Number is 10");
			        break;
			    case 20:
				    System.Console.WriteLine("Your Number is 20");
			        break;
	        /*You can also join multple switch conditions and it falls from one condition to another*/
			    case 30:
			    case 40:
			    case 50:
				    System.Console.WriteLine("Your Number is {0}", userInput);
                    break;
			    default:
				    System.Console.WriteLine("Default number is neither 10 nor 20");
                    break;
		}
        }
    }
}
