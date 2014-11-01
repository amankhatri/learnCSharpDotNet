using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Vs_Interfaces
{
    /*1)Abstract classes can have implementations for some of its members(methods), but the interface can't have implementation for any of its
     members
     2)  Interfaces cannnot have fields (ints or strings) where as an aabstract class can have fields.
     3) An interface can inherit from another interface only and cannot inherit from an abstract class, where as an abstract class can inherit 
     from another abstract calss or another interface.
     3) A class can inherit from multiple interfaces at the same time where as a class cannot inherit from multiple classes at the same time, including
     the abstract classes.
    4) Abstract class members can have access modifiers where as interface members(methods) cannot have access modifiers.*/
    public abstract class Customer
    {
        public void NormalPrint()
        {
            System.Console.WriteLine("Nomal method from abstracts");
        }
        public abstract void NormalPrint();
    }
    interface I1
    {
        public void interfaceNormalPrint();
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
