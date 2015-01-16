using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_What_is_dictonary
{
    /*Methods of dictonary class
     1) TryGetValue()
     2) Count()
     3) Remove()
     4) Clear()
     5) Using LINQ extension methods with dictionary
     6) Different ways to convert an array into a dictionary*/
    class Program
    {
        /*1) A dictionary is a collection of(key,value) pair. we need to specify the type of key and value, the fasted way to
         * find anything in dictionary is to use keys
         2) Dictonary class is present in System.Collections.Generic namespace.
         3) When creating a dictionary, we need to specify the type for key and vallue.
         4) Dictionary provides fast lookups for values using keys.
         5) Keys in the dictionary must be unique. if we have two customers with same keys it gives us a run time exception.*/
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
            Customer customer2 = new Customer() { ID = 110, Name = "Pam", Salary = 6500 };
            Customer customer3 = new Customer() { ID = 119, Name = "John ", Salary = 3500 };
            /*for creating a dictionary we need key which is an int in this case and a value which is customer object*/
            Dictionary<int, Customer> CustomerDictonary = new Dictionary<int, Customer>();
            CustomerDictonary.Add(customer1.ID, customer1);
            CustomerDictonary.Add(customer2.ID, customer2);
            CustomerDictonary.Add(customer3.ID, customer3);
            /*if we are not sure if key exists or not we can use TryGetValue*/
            Customer customerTryValue;
            if (CustomerDictonary.TryGetValue(101, out customerTryValue))
            {
                Console.WriteLine("ID " + customerTryValue.ID + ", Name " + customerTryValue.Name);
            }
            else { Console.WriteLine("Key Not Found"); }

            /* using count fucntion to count number of customers in dictonary*/
            Console.WriteLine( "Total Customers in Dictonary: " + CustomerDictonary.Count);
            
            /*we can also use function count()*/
            Console.WriteLine("Total Customers in Dictonary: " + CustomerDictonary.Count());

            /*there are aditional count method which can be overloaded to get specific customers, in this case 
             we will try to get customers with salary higher than 4000*/
            /*dictonary.count(keyvaluePair =>(such that) keyvaluepair.value)*/
            Console.WriteLine("Total " + CustomerDictonary.Count(kvp => kvp.Value.Salary >4000));

           /*Removing an item from dictonary, if key doesn't exists then this functoin wil not throw error*/
            CustomerDictonary.Remove(999);
            /*Remove everything from dictonary by using CustomerDictonary.Clear()*/

            /*Converting Customer array into dictonary type, you can also convert list of customers*/
            Customer[] CustomerArray = new Customer[3];
            CustomerArray[0] = customer1;
            CustomerArray[1] = customer2;
            CustomerArray[2] = customer3;
            /*we have to specify what is key and what is value*/
            /*array.ToDictonary(key => object.propert, value => object.property or just an object) this returns a dictonary*/
            Dictionary<int, Customer> dict = CustomerArray.ToDictionary(cust => cust.ID, cust => cust);
            /*verigying if everything has been added to dictionary*/
            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Console.WriteLine("Key : " + kvp.Value.ID);
            }
            /*List of customers*/
            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            Dictionary<int, Customer> ListTodict = customerList.ToDictionary(cust => cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> kvp in ListTodict)
            {
                Console.WriteLine("Key : " + kvp.Value.ID);
            }



        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }
}
