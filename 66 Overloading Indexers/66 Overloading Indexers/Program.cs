using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Overloading_Indexers
{
    class Program
    {
        /*Indexers are keys which can be strings or integers. INdexers allow instances of class to be indexed just like arrays
         Use this keyword to creawte an indexer
         This indexer takes emploteeId as parameter
          and returns employee name;*/
        static void Main(string[] args)
        {
            Company company = new Company();
            System.Console.WriteLine("Name of Employeee with id = 2" + company[2]);
            System.Console.WriteLine("Chaning the name of the employess with id = 2, 5, and 8");
            company[2] = "Jake2";
            company[5] = "Jake5";
            company[8] = "Jake8";
            System.Console.WriteLine("Name of Employeee with id = 2" + company[2]);
            System.Console.WriteLine("Name of Employeee with id = 5" + company[5]);
            System.Console.WriteLine("Name of Employeee with id = 8" + company[8]);
            System.Console.WriteLine("Total Male employee " + company["Male"]);
            System.Console.WriteLine("Total Female employee " + company["Female"]);
            company["Male"] = "Female";
            System.Console.WriteLine("After changes");
            System.Console.WriteLine("Total Male employee " + company["Male"]);
            System.Console.WriteLine("Total Female employee " + company["Female"]);
        }
    }
}
