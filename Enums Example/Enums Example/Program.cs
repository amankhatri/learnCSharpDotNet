using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Make Enums which is similar to class
 change the type of the data to Specific enum type like in class customer we changed int gender to Gender (enum) type
 now we replace the cases in switch conditions to Gender.Male or Gender.Female etc
 third change occurs when we assign the value of gender to customer.
 There are some default enums which come with dot nets for example System.IO.FileShare.ReadWrite or anything readWrite may be a number but it
 is represented in readable form*/
namespace Enums_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customer[1] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customer[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };
            foreach (Customer c in customer)
            {
                System.Console.WriteLine("Name = {0} && Gender = {1}", c.Name, GetGender(c.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown :
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data";
            }
        }
    }
    /*Enums are value types*/
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    // gender 0 = unknown
    // gender 1 = Male
    // Gender 2 = Female
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
