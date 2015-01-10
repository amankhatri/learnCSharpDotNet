using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Generics are introduced in C3 2.0. Generics allow us to design classes and methods decoupled from the data types.
 
 * Genercs classes are extensively used by colleciton classes available in system.collections.generic namespace. 
 
 * One way of making AreEqual() method reusable, is to use object type parameters. Since, every type in .NET directly or indirectly inherit from 
 system.object type, AreEqual() method works with any data type , but the problem is performance degradation due to boxing and unboxing happening.
 
    Also, AreEqual() method is no longer type safe. Itis now possible to pass integer for the first parameter, any a string for the second parameter.
 it doesn't really make sense to compare strings with integers
 
 So, the problem with using System.Object type is that
 1) AreEqual() method is not type safe
 2) Performance degradation due to boxing and unboxing.
 */
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal1 = Calculator.AreEqual1(1, 2);
            if (Equal1) { System.Console.WriteLine("Equal"); }
            else { System.Console.WriteLine("Not Equal"); }
            bool Equal2 = Calculator.AreEqual2("A", "A");
            if (Equal2) { System.Console.WriteLine("Equal"); }
            else { System.Console.WriteLine("Not Equal"); }

            /*Generics methods*/
            bool Equal3 = Calculator.AreEqual3<string>("A", "A");
            if (Equal3) { System.Console.WriteLine("Equal"); }
            else { System.Console.WriteLine("Not Equal"); }

            /*Generics class: */
            bool Equal4 = GenericCalculator<int>.AreEqualinGenericClass(10,10);
            if (Equal4) { System.Console.WriteLine("Equal"); }
            else { System.Console.WriteLine("Not Equal"); }
        }
    }
    public class Calculator
    {
        /*this method will exclusively compare two integers, it can not compare strings or chars, this method is tightly coupled*/
        public static bool AreEqual1(int Value1, int Value2)
        {
            return Value1 == Value2;
        }
        /*to make it work for all datatypes we can declare arguments as objects. This makes it reusable for anytype. That is because all the datatypes 
         inherits from System.object. However there are two issues with this method:
         1) if we do Calculator.AreEqual2(10, 10); then we would have to convert 10 from value type to reference type, this is called boxing, which 
         happens here unnesserily, here and it is inefficient. 
         2) we can also do Calculator.AreEqual2(10, "AB") and program will still compile
         we can slove those problems by using generics*/
        public static bool AreEqual2(object Value1, object Value2)
        {
            return Value1 == Value2;
        }
        /*Generic methods 
         nameofMethod<T Type>(<t type> variable1, <t type> variable2)*/
        public static bool AreEqual3<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
    /*we can also make generic classes, <T> can be anything <A> , <B> blah*/
    public class GenericCalculator<T>
    {
        public static bool AreEqualinGenericClass(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
