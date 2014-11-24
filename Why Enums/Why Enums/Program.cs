using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_Enums
{
    /*Enums are strongly typed constants. If a program uses set of integral numbers, consider replacing them with enums.
     otherwise the program becomes less Readable and Maintainable. 
     In next session we will replace these integral numbers with enums which makes the prgram better readable and maintaiable*/
    public  class Program
    {
        static void Main(string[] args)
        {

            Customer[] customer = new Customer[3];
            customer[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };
            customer[1] = new Customer
            {
                Name = "Mary",
                Gender = 2
            };
            customer[2] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };
            foreach (Customer c in customer)
            {
                System.Console.WriteLine("Name = {0} && Gender = {1}", c.Name, GetGender(c.Gender));
            }
        }
        //now there can be several numbers related to gender and we want to display string gender to have a more visible relation ship it makes 
        //programming easy and visible 
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0 :
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid Data"
            }
        }
    }
   // gender 0 = unknown
    // gender 1 = Male
    // Geneder 2 = Female
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }

}
