using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_why_to_override_toString_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;
            System.Console.WriteLine(Number.ToString());

            Customer c1 = new Customer();
            c1.FirstName = "Simon";
            c1.LastName = "Tan";
            /*now here is when we need to use ToString Over ride function because c1.string() will return namespace.classname , so we want to
             tell it what to print*/
            System.Console.WriteLine(c1.ToString());
            /*or you can use convert class too*/
            System.Console.WriteLine(Convert.ToString(c1));
            
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /*we can override three methods from object classs, that is Equals, GetHashCode and ToString methods*/
        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName;
        }
    }
}
