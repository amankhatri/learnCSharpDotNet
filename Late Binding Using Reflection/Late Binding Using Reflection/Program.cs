using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Late_Binding_Using_Reflection
{
    /*Difference between early and late binding:
     1) Early binding can flag erros at compile time. With late binding there is a risk of run time exceptions.
     2) Early binding is much better for performance and should always be preferred over late binding. Use late binding only when working with an
     object that are not available at compile time.*/
    class Program
    {
        static void Main(string[] args)
        {
            /*Early binding example: In early typing you can't make spelling mistakes or name missmatch, and all the errors will be detected at runtime*/
            Customer1 C1 = new Customer1();
            string fullName = C1.GetFullName("Pragim", "Tech");
            System.Console.WriteLine("Full Name: " +fullName);
            /*suppose a class is not avaible at compile time then you use late binding
             1) load assembly which has your class :*/
            Assembly executingAssembly = Assembly.GetExecutingAssembly(); //within this executing assemly (program class) get then you get the type of
            //specified class
            /*1b get the type of the customer2 from assemnly*/
            Type customerType2 = executingAssembly.GetType("Late_Binding_Using_Reflection.Customer2"); 
           /*Now 2) isntantiate the class variabel of type customerType2*/
            object customerType2Instance= Activator.CreateInstance(customerType2); /*Activating object of customerType2*/
            MethodInfo getFullName2 = customerType2.GetMethod("GetFullName2");
            /*creating string array to store firstname and last name*/
            string[] parameters = new string[2];
            parameters[0] = "First";
            parameters[1] = "Last";
            /*invoking method getFullName2 using invoke */
            string fullName2 = (string)getFullName2.Invoke(customerType2, parameters);
           Console.WriteLine("FullName 2 " + fullName2);

            System.Console.ReadLine();
        }
    }
    public class Customer1
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
    public class Customer2
    {
        public string GetFullName2(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }

}
