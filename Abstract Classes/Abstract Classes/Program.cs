using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    /*To create a abstract class we use Abstract keyword. Abstract class are incomplete. You can not create instances for abstract classes, 
     * however it can act as a base for other classses.*/
        public abstract class Customer
    {
        //when we use abstract method we can not have method implementation in the method.
        public abstract void Print();
            /*you can also have the whole method in the class*/
        public void NormalMethod()
        {
            System.Console.WriteLine("Regular Method");
        }
    }
    /*all the classes which inherits from abstract class and has to have method implementations of unimplemented method from abstract class.
     An abstract class may contain abstract members(methods, properties, indexers and events), but not mandatory.
     A non abstract class derived from an abstract class must provide implementations for all inherited abstract members. 
     If a class inherits an abstract class there are 2 options avaibale for that class
     option1 : provide nimplementation for alll the abstract members inherited from the base abstract class
     option2: If the class does not wish to provide implementation for all the abstract members inherited from the abstract classs, then the 
     class has o be masrked as abstract.*/
    public class Program : Customer
    {
        static void Main(string[] args)
        {
            Customer C1 = new Program();
            C1.Print();
            C1.NormalMethod();
            //or
            Program P1 = new Program();
            P1.Print();
            P1.NormalMethod();
            
            System.Console.ReadLine();
        }

        public override void Print()
        {
            System.Console.WriteLine("Overiding methods of abstract class.");
        }
    }
}
