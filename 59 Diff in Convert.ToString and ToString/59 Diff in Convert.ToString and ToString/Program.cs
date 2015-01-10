using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_Diff_in_Convert.ToString_and_ToString
{
    /*Convert.ToString() handles null, while ToString() doesn't  and throws a null reference exception
     
     Depending onthe type of the application and architecture and what you are trying to achieve, you choose one over the other
     
     for example if you want a customer to be non empty you would use tostring method to get an exception.*/
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            /*tp string method is from system.object class*/
            String str = c1.ToString();
            System.Console.WriteLine(str); // returns namespace.classname
            string str2 = Convert.ToString(c1);
            /*if c1 is initialized to null and we use to string method in covert class, the convert class converts null into the " " empty string 
             where as c1.tostring method returns an error because c1.tostring is a instance method. so when you call instance method it returns error*/
        }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
}
