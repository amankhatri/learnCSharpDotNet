using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    /*Assembly consist two parts one is intermediate language and metadata , meta data contains the name of the classes and its methods
     * Reflection is taking the assembly and inspecting the structor of a given program
     * Relection is the abiilty of inspecting an assmblies metadata at runtime
     it is used to find all types in an assembly and or dynamically invoke methods in an assembly
     Uses of Reflection:
     1) When you drag and drop a button on a win forms or an asp/net applicaion. The properties window uses reflection to show all the properties
     of the button class. So reflection is extensively used by IDe or a UI designers.
     example 2) Laste binding can be achieved by using reflection. You can use reflection to dunamically create an instance of a type, about which we don't 
     have any information at compile time. So, reflection enables you oto use code that is not available at compile time.
    example 3) Consider an example where we have two alternate implementation of an infterface. you want  to allow the user to pick one or the other
     using a config file. With reflection, you can simply read the name of the class whoes implementation you want to use from the config file, 
     and instantiate an instance of that class. This is another example for late binding using reflection.*/
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(); /*creating instance of class customer at compile time so this is early biniding 
                                           where as if there is a class and we create an instance latter on while the program is running you would 
                                           have to check if the class of which we have to create an object is present. This can be done by reflection
                                           You have to have knowledege about a class before you create instance*/
            /*if we want to make a program to list the fields and methods in a class we use reflection*/
            Type T = Type.GetType("Reflection.Customer"); // we are trying to get all the properties of the Customer class using Reflection
            /*you can also use type of key word for example Type T = typeof("Customer") you may come accross a  scenario where you have
             instance name and you don't know the class name you can call method on instance of the class to know about the class Type T = C1.GetType()*/
            Console.WriteLine("Full name of the class " + T.FullName);
            Console.WriteLine("Just the name of the class " + T.Name);
            Console.WriteLine("Just the name of the Namespace " + T.Namespace);
            Console.WriteLine("Properties of Class Customer");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine(prop.PropertyType.Name + " " + prop.Name);
            }
            System.Console.WriteLine("Name of the Methods");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                System.Console.WriteLine(method.ReturnType + " " + method.Name);
            }
            System.Console.WriteLine("Name of the Constructors");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                System.Console.WriteLine("Returned Custructor name is " + constructor.Name);
                System.Console.WriteLine("To String method on constructor returns more info" + constructor.ToString());
            }
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            System.Console.WriteLine("ID = {0} ", this.Id);
        }
        public void PrintName()
        {
            System.Console.WriteLine("Name = {0} ", this.Name);
        }

    }

}
