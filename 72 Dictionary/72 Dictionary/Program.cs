using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _72_Dictionary
{
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
            /*if we are not sure if a key is present in dictonary or not we can do this*/
            if (!CustomerDictonary.ContainsKey(customer1.ID)) { CustomerDictonary.Add(customer1.ID, customer3); }
            /*we will use key to retrieve info from dictionary*/
            Customer customer119 = CustomerDictonary[119];
            Console.WriteLine("ID = " + customer119.ID + ", Name " + customer119.Name + ", Salary " + customer119.Salary);
            /*we can loop through each customer in a dictonary, dictonary is not a collection of customer, it is a collection of ids and customer 
             unlike list which is collection specific objects
             */
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in CustomerDictonary)

            /*you can also do foreach (var customerKeyValuePair in CustomerDictonary), which means var is implicitly declared variable*/
            {
                Console.WriteLine("ID "+ customerKeyValuePair.Key);
                Console.WriteLine("Customer Value " + customerKeyValuePair.Value); //returns namespace.class
                Customer buyer = customerKeyValuePair.Value;
                Console.WriteLine("ID " +buyer.ID + ", Name: " + buyer.Name +", Salary: " +buyer.Salary );
                Console.WriteLine("------------------------------------------------------------------");
            }
            /*looping through the keys*/
            foreach (int keys in CustomerDictonary.Keys)
            /*you can also do foreach (var customerKeyValuePair in CustomerDictonary), which means var is implicitly declared variable*/
            {
                Console.WriteLine("Print Key: " + keys);
                Console.WriteLine("Print Key: " + CustomerDictonary[keys]);
                Console.WriteLine("Print Name: " + CustomerDictonary[keys].Name);
            }
            /*looping using values */
            foreach (Customer values in CustomerDictonary.Values)
            /*you can also do foreach (var customerKeyValuePair in CustomerDictonary), which means var is implicitly declared variable*/
            {
                Console.WriteLine("Print Key: " + values);
                Console.WriteLine("Print Name: " + values.Name);
            }
            /*before retriving things from dictonary we have to make sure that key should exists in dictonary*/
            if (CustomerDictonary.ContainsKey(customer1.ID)) { CustomerDictonary.Add(customer1.ID, customer3); }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
       

    }
    /**/
   
}
