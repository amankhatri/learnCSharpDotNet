using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_List_Collection
{
    class Program
    {
        /*Functions of Lists
         1) Contains() function: Checks if an item exists in the list. This method returns true if the items exists, else false
         2)Exists() function: Checks if an item exists in the lsit based on a confition,. This method returns true if the item exists, else false
         3) Find() Function: Searches for an element that matches the conditions defined by the specified lambda expression and returns
         the first macthing item from the list. It returns the object
         4) FindLast() function: Searches for an element that matches the conditions defined by the specified lambda expression 
         and returns the last matching item from the list
         5) FindAll() function: Returns al the items from the list that match the conditions specified by the lambda expression
         6) FindIndex() function: Returns the index of the first item , that matches the condition specified by the lambda expression.
         There are two other overloads of this method which allows us to specify the range of elements to search, with in the list
         7) FindLastIndex() function: Returns the index of the last item, that matches the condition specified by the lambda expression.
         There are 2 other overloads of this method which allows us to specify the range of elements to search, with in the list
         Convert an array to List - use ToList() method
         Convert a list to an Array - use ToArray() method
         convert a list to a dictionary - Use toDictionary() method*/
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
            Customer customer2 = new Customer() { ID = 110, Name = "Pam", Salary = 6500 };
            Customer customer3 = new Customer() { ID = 119, Name = "John ", Salary = 7000 };
             /*List: Size Increases automatically*/
            List<Customer> customerList = new List<Customer>(2);
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            if (customerList.Contains(customer3))
            {
                Console.WriteLine( "Contains Customer 3" );
            }
            else
            {
                Console.WriteLine("The Item Does not exists");
            }
            if (customerList.Exists(cust => cust.Name.StartsWith("P"))) //Lambda Expression
            {
                Console.WriteLine("Customer with name starting with P exists");
            }
            else
            {
                Console.WriteLine("Customer with name starting with P does not exists");
            }
            int salary = 5000;
            try
            {
                /*only returns first object*/
                Customer c = customerList.Find(cust => cust.Salary > salary);
                if (!c.Equals(null)) //Lambda Expression
                {
                 Console.WriteLine("Customer with with salary higher than {0}  exists",salary);
                }
            }
            catch (NullReferenceException)
            {
                
                Console.WriteLine("Customer with with salary higher than {0}  does not exists", salary);
            }

            try
            {
                /*only returns only the last matchin object*/
                Customer c = customerList.FindLast(cust => cust.Salary > salary);
                if (!c.Equals(null)) //Lambda Expression
                {
                    Console.WriteLine("Customer with with salary higher than {0}  exists", salary);
                }
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("Customer with with salary higher than {0}  does not exists", salary);
            }
            List<Customer> returnedCustomerList = new List<Customer>();            
            try
            {
                
                /*only returns the "list" of all matchin object*/
                returnedCustomerList = (customerList.FindAll(cust => cust.Salary > salary));
                if (!returnedCustomerList.Equals(null)) //Lambda Expression
                {
                    Console.WriteLine("Customer with with salary higher than {0}  exists", salary);
                }
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("Customer with with salary higher than {0}  does not exists", salary);
            }
            foreach (Customer customer in returnedCustomerList)
            {
                Console.WriteLine("Customer Details: " + customer.ID);
            }

            /*Overload 1*/
            int index1 = customerList.FindIndex(cust => cust.Salary > salary);
            Console.WriteLine("Index of customer with salaray higher than {0} is {1}", salary, index1 );
            /*Overload 2: you can also specify the start index, where do you want it to start*/
            int index2 = customerList.FindIndex(2,(cust => cust.Salary > salary));
            Console.WriteLine("Index of customer with salaray higher than {0} is {1}", salary, index2);
            /*OverLoad 3: you can specify which index you want to start from and how many items are you looking for */
            int index3 = customerList.FindIndex(1, 2, (cust => cust.Salary > salary));
            Console.WriteLine("Index of customer with salaray higher than {0} is {1}", salary, index3);
            /*It has same number of overloads and are same as FindIndex*/
            int index4 = customerList.FindLastIndex((cust => cust.Salary > salary));
            Console.WriteLine("last Index of customer with salaray higher than {0} is {1}", salary, index4);
        /*Converting array to list*/
            Customer[] customersArray = new Customer[3];
            customersArray[0] = customer1;
            customersArray[1] = customer2;
            customersArray [2] = customer3;
            List<Customer> ListFromArray = customersArray.ToList();
        /*Converting list to array*/
            List<Customer> customerListToArray = new List<Customer>(2);
            customerListToArray.Add(customer1);
            customerListToArray.Add(customer2);
            customerListToArray.Add(customer3);
            Customer[] ListToArray = customerListToArray.ToArray();
            /*List to dictionary*/
            List<Customer> customerListToDictionary = new List<Customer>(2);
            customerListToDictionary.Add(customer1);
            customerListToDictionary.Add(customer2);
            customerListToDictionary.Add(customer3);
            Dictionary<int, Customer> listToDictionary = customerListToDictionary.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int,Customer> kvp in listToDictionary)
            {
                Console.WriteLine("Key: " +kvp.Key);

            }


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
