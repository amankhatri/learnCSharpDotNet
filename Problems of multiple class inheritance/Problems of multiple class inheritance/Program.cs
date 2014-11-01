using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_of_multiple_class_inheritance
{
    class A
    {
        public virtual void print()
        {
            System.Console.WriteLine("A Implementation");
        }
    }
    
    class B : A
    {
        public override void print()
        {
            System.Console.WriteLine("B Implementation");
        }
    }
    class C : A
    {
        public override void print()
        {
            System.Console.WriteLine("C Implementation");
        }
    }
    /*if method in D calls a method defined in A (And does not override the method) and B and C has overriden that method differently then from 
     which class does it inherit: B or C? This ambiguity is called as diamond problem*/
    /*athough we know that the mutiple class inheritance in not allowed in dot net lets pretend that it is allowed for time being*/
    class D :B, C
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
