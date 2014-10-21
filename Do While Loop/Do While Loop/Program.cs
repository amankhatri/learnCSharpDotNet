using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "";
            do 
            {
                int start=0;
                System.Console.WriteLine("Please Enter a target number");
                int userInput = int.Parse(System.Console.ReadLine());
                while(start<= userInput){
                    System.Console.WriteLine("Start: "+start);
                    start = start + 2;
                }
               
                do
                {
                    System.Console.WriteLine("Do you want to continue - yes or no? ");
                    userChoice = System.Console.ReadLine();
                    if (userChoice!= "yes" && userChoice!= "no")
                    {
                        System.Console.WriteLine("Invalid choice. please say yes or no");
                    }
                } while (userChoice!= "yes" && userChoice!= "no");
            } while (userChoice == "yes");
            System.Console.WriteLine("Done!");
        }
    }
}
