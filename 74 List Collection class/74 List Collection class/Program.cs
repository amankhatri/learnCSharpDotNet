using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_List_Collection_class
{
    /*List is one of the generic collection classes present in System.Collections.Generic namespace. There are sevelra generic collection
     * classes in System.Collection.Generic namespace as llisted below
     * 1) Dictionary 
     * 2) List
     * 3) Stack 
     * 4) Queue etc
     * 
     * A list class can be used to create a collection of anytype.
     For example we can create alist of Integers, Strings and even complex types. 
     the objects stored in the list can be accessed by index.
     Unlike arrays, lists can grow in size automatically.
     This calss also provides methods to search, sort, and manipultae lists
     */
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
            Customer customer2 = new Customer() { ID = 110, Name = "Pam", Salary = 6500 };
            Customer customer3 = new Customer() { ID = 119, Name = "John ", Salary = 7000 };
            /*Array: size of array is two and if we give it more than two arrays it will give us error*/
            Customer[] customersArray = new Customer[2];
            customersArray [0] = customer1;
            customersArray [1] = customer2;
            //customersArray [2] = customer3;

            /*List: Size Increases automatically*/
            List<Customer> customerList = new List<Customer>(2);
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            /*we can retrieve customer by the list indexes like:*/
            Customer c = customerList[0];
            Console.WriteLine("Customer Details: " + "ID: " + c.ID);
            /*Looping through each customers*/
            /*foreach (var item in collection)
            {
             * syntax of foreach loop   
            }*/
            foreach (Customer customer in customerList)
            {
                Console.WriteLine("Customer Details: " + "ID: " + customer.ID);
                
            }
            for (int i=0; i<=customerList.Count-1; i++) {
                Console.WriteLine("Customer Details" + "ID: " + customerList[i].ID);
            }
            SavingsCustomer sc = new SavingsCustomer();
            /*since Savings Customer is inherting from Customer class I can add it in List<Customers> , that is the list of type customer
             so Customer and Saving Customers are closesly tied*/
            List<Customer> customerSavingsList = new List<Customer>(2);
            customerSavingsList.Add(sc);
            /*we can also insert an element in list at a specific position or index, */
            customerList.Insert(10, customer2);
            foreach (Customer customer in customerList)
            {
                Console.WriteLine("Customer Details: " + "ID: " + customer.ID);
            }
            /* You can also find the index of specific object in list*/
           /*if we try to find the index of element which has been added twice to the list, it returns the first index at which the object exists*/
            Console.WriteLine("Index number of a customer which has been added twice: " + customerList.IndexOf(customer2));
            /*you can also start looking from cetrain index number using overloading in Index of Method*/
            Console.WriteLine("Index number of a customer which has been added twice: " + customerList.IndexOf(customer2,2));



        }
  
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }

    public class SavingsCustomer : Customer
    {
        /*inherits from customer*/
    }
    
}
