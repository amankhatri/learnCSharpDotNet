using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClass_Inheritance_using_interfaces
{
    interface IA
    {
        void Amethod();
    }
    class A : IA
    {
        public void Amethod()
        {
            System.Console.WriteLine("A");
        }
    }
    interface IB
    {
        void BMethod();
    }
    class B : IB
    {
        public void BMethod()
        {
            System.Console.WriteLine("B");
        }
    }
    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void AMethod()
        {
            a.Amethod();
        }
        public void BMethod()
        {
            b.BMethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
            System.Console.ReadLine();
        }
    }
}
