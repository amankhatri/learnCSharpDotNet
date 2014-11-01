using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*Strcuts are value type , dalegates and classes are reference type. A delegate is type safe fuction pointer. It points to a functions and 
     when you call the delegate it invokes the function. We can call a function directly but delegates give us flexibility. To create a 
     delegate we use delgate key word. To remember the sytance of delegate key word think of it as a method 
     public delegate type nameofdelegate();. Delgate can point to any function which is of void type and take in an string. we can also create
     an instance of delegate*/
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        static void Main(string[] args)
        {
            /*poiting a delegate to point to hello function like this:*/
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            //passing method to Hello Method
            del("Hello from Delegate");
            /*Type safe function means that the value of return type of the delegate and the function which delegate is pointing to should be same.
             A signatue of the delegate must match the signature of the function, the delegate points to, otherwise you get a complier error. This is
             the reason delegates are called as type sage function pointers. 
             A delegate is similar to a class. You can create an instance of it. and when you do so you pass in the function name as a paramet to the 
             delegate constructor and it is to this fucntion the delegate will point to*/
            System.Console.ReadLine();
  
        }
        public static void Hello(string strMessage)
        {
            System.Console.WriteLine(strMessage);
        }

    }
}
