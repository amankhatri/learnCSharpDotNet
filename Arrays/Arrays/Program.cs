using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Advantages : Arrays are strongly typed
             Disadvantages: Arrays cannot grow in size once initialized. Have to rely on integral indeces to store or retrieve items from array*/
            int[] EvenNumbers1 = new int[3];
            EvenNumbers1[0] = 0;
            EvenNumbers1[1] = 2;
            EvenNumbers1[3] = 4;
            System.Console.WriteLine("EvenNumber1: " +EvenNumbers1 );
        }
    }
}
