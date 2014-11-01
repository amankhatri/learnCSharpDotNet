using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*We create interfaces using interface keyword. Just like classes interfaces also contains properties, moethods, delegates or events, but only 
     declarations and no implementations. 
     It is a complie time error to provide implementations for any interface member. Interface memers are public by default and they don't allow explicit access modifiers.
     Interfaces cannot contain fields. If a class or a struct inherits from an interface. it must provide implementation for all interface members. Otherwise, we get a compiler 
     error
     A class or a struct can inherit from more than one interface at the same time, but wjhere as, a class cannot inherit from more than once class at the
     same time.
     Interfaces can inherit from other interfaces. A class that inherits this interface must provide implementation for all interface members in the entire
     interface inheritance chain.
     we can not create an instance of an interface, but an interface reference variable can point to a derivied class object.
         interface naming convention: interface names are prefixed with capital I*/
   
    interface ICustomer1
    {
        /*on inteface methods you can not have access modifiers, Interface can not have feilds like int Id.*/
        void Print1();

    }
    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Customer : ICustomer2
    {

        public void Print2()
        {
            System.Console.WriteLine("method from ICustomer2");
        }

        public void Print1()
        {
            System.Console.WriteLine("method from ICustomer");
        }
    }

    /*a class cannot inherit from another class.*/
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print1();
            c1.Print2();
            /*You cannot do this ICustomer1 cust = new Icustomer1(); if you do Customer c1 = new Customer(); c1 is an object on heap and
             everytime you do c1. something, it refers to c1 object on heap. However you can do this:*/
            ICustomer1 cust = new Customer(); /*As we know that a parent class object can refer to the child class object.*/
            cust.Print1();
            System.Console.ReadLine();

        }
    }
}
