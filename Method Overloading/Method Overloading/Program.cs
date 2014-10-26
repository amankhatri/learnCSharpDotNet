using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        /*Method overloading allows a class to have multiple methods with the same name, buit with a different signature.
         In C sharp functions can be overloaded based on the number, type(int, float etc), and kind(value, ref or out) of parameters The 
         signature of method does not include the return type and the params modifier. So it is not possible to overload a function, 
         just based on the return type or params modifier. */
        static void Main(string[] args)
        {
            int Total;
            Add(5 , 6);
            Add(5, 6, out Total);
        }
        public static void Add(int first, int second)
        {
            System.Console.WriteLine(first + second);
        }
        public static void Add(float first, float second, float third)
        {
            System.Console.WriteLine(first + second+ third);
        }
        public static void Add(float first, int second, int third , int fourth)
        {
            System.Console.WriteLine(first + second + third + fourth);
        }
        public static void Add(int first, int second, out int sum)
        {
           sum = first + second;
        }
        public void Add(int First, int Second, params int[] TN)
        {
            /*optional parameters = params*/
            /*By using the params keyword, you can specify a method parameter that takes a variable number of arguments.
You can send a comma-separated list of arguments of the type specified in the parameter declaration or an array of arguments of the specified type. You also can send no arguments. If you send no arguments, the length of the params list is zero.
No additional parameters are permitted after the params keyword in a method declaration, and only one params keyword is permitted in a method declaration.
Example
The following example demonstrates various ways in which arguments can be sent to a params parameter.
C#
public class MyClass
{
    public static void UseParams(params int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    public static void UseParams2(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // You can send a comma-separated list of arguments of the  
        // specified type.
        UseParams(1, 2, 3, 4);
        UseParams2(1, 'a', "test");

        // A params parameter accepts zero or more arguments. 
        // The following calling statement displays only a blank line.
        UseParams2();

        // An array argument can be passed, as long as the array 
        // type matches the parameter type of the method being called. 
        int[] myIntArray = { 5, 6, 7, 8, 9 };
        UseParams(myIntArray);

        object[] myObjArray = { 2, 'b', "test", "again" };
        UseParams2(myObjArray);

        // The following call causes a compiler error because the object 
        // array cannot be converted into an integer array. 
        //UseParams(myObjArray); 

        // The following call does not cause an error, but the entire  
        // integer array becomes the first element of the params array.
        UseParams2(myIntArray);
    }
}*/
        }
    }
}
