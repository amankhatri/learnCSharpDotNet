using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*goal print even numbers upto a given target*/
		    System.Console.WriteLine("Please Enter your target?");
		    /*System.Console.ReadLine reads the input arguments as strings so we need to parse*/
		    int userInput = int.Parse(System.Console.ReadLine());
		    int start = 0;
		    while(start <= userInput)
            {
		        System.Console.WriteLine(start);
		        start = start +2;
            }
}
