using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*A class consists of data and behavior. Class data is represented by its field and behavior is represented by its methods.
 we can make a customer, with customer id customer name and other relavent fields . A class has a state and behaviour. State means data variables 
 and behavior is methods. */
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*C1 is a instance of customer*/
            Customer C1 = new Customer("Pragim", "Technologies");
            /*After declaring default constructor we can also do this*/
            Customer C2 = new Customer(); // since we have more than one constructor this is called constructor over loading.

            C1.PrintFullName();
            C2.PrintFullName();
        }
    }
    class Customer
    {
        
        string _firstName;
        string _lastName;
        /*class can have a construtor. Accessmodifier nameofclass () . Constructors are used to initialize class fields. Constructor doesn't have a 
         return type. Constructors are called when you create an instance of a class and is use to initialize class memebers. We don't always have to
         have constructors. Dot net always have default constructor. Remember you can have more than one constructor.*/
        public Customer()  
            :this("No FirstName Provided", "No LastName Provided")
    {
            /*if we want a constructor with no parameters then we can have something like this. This constructor which is a default
             * constructor , will call the constructor with parameters.
             parameters and */
    }
        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            /*I can refer to the class fields by putting this in front of the states or the variables*/
           this._lastName = LastName;
        }
        /*Class can also have distructors. they have same name as class and they are declared as ~classname, it takes no parameters. And you need not 
         call destructors and it is used for cleaning objects in memory and for garbage collections. The clean up code goes in destructors. It frees the resources used
         */
        ~Customer()
        {
            /*clean up code goes here*/
        }
        public void PrintFullName()
        {
            System.Console.WriteLine("Full Name: " + this._firstName + " " + this._lastName);
        }

    }
}
