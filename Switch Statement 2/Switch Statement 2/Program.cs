using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeeCost = 0;
		    Start:
		    System.Console.WriteLine("1 - Small, 2 - Medium, 3- Large");
		    int userInput = int.Parse(System.Console.ReadLine());
		    switch(userInput){
		        case 1:
			        totalCoffeeCost = totalCoffeeCost+1;
		        break;
		        case 2:
			       totalCoffeeCost += 2;
		        break;
		        case 3:
			        totalCoffeeCost += 3;
		        break;
		        default:
			        System.Console.WriteLine("Your Choice {0} is invalid", userInput);
		        break;
		}	
		    makeDecision:
		    System.Console.WriteLine(" Do you want to by another Coffee - Yes or No?");
		    String userDecision = System.Console.ReadLine();
		    switch(userDecision.ToUpper())
		    {
			    case "Yes":
                /*Now we want to go reexecute the menu part to show the menu again. So we use
                labels and lets say the name of the lable is S tart*/
                    goto Start;
			    /*we don't have to break the go to condition*/
			    case "No":
				    System.Console.WriteLine("Thank You for Shopping");
			    break;
			    default:
				    System.Console.WriteLine("You Choice {0} is Invalid ", totalCoffeeCost);
				    goto makeDecision;
			    break; /*this line is never reached so we can delete break*/
		}

        }
    }
}
