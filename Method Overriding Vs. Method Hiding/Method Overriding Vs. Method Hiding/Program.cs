using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding_Vs.Method_Hiding
{
    class Program
    {
        /*In method overriding a base class refence variable pointing to a child class object, will invoke the override method in the child
         override uses they key word override*/
        /*In method hiding a base class refence variable pointing to a child class object will invode the hidden method in the base class*/
        static void Main(string[] args)
        {
            BaseClass B1 = new DerivedClassforMethodOverriding();
            BaseClass B2 = new DerivedClassforMethodHiding();
            DerivedClassforMethodOverriding D1 = new DerivedClassforMethodOverriding();
            DerivedClassforMethodHiding D2 = new DerivedClassforMethodHiding();
            B1.Print();
            B2.Print();
            D1.Print();
            D2.Print();
            System.Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public virtual void Print()
        {
            System.Console.WriteLine("I am a Base Class");
        }
    }
    public class DerivedClassforMethodOverriding : BaseClass
   {
       public override void Print()
       {
           System.Console.WriteLine("I am a derived class for method overriding Class");
       }
   }
   public class DerivedClassforMethodHiding : BaseClass
   {
       public new void Print()
       {
           System.Console.WriteLine("I am a derived class for method hiding");
       }
   }
}
