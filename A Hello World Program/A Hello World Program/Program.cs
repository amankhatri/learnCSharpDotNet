/*The first line here is called namespace. It tells the program that we will use the code present in system name space
 */
/*Namespace is collection of variety fo things. It is a collection of classes, interfaces, structs, enums and delegates.
 A namespace can contain another name space*/
using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*we are using console class present in the system namespace.*/
            Console.WriteLine("Hello World 1");
            /*you can also do this: */
            System.Console.WriteLine("Hello World 2");
            Console.ReadLine();
        }
    }
