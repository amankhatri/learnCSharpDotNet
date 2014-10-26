using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_Classes_and_Structs
{
    /*Just like classes structs can have fields, properties constructores and methods.
     * 
     * A struct is a value type where as a class is a 
     reference type. All the differences that are applicable to value types and reference types are also applicable to to classes and structs

     * Struct are stored on stacks , where as classeds are stored on the heap.
     * 
     value types hold their value in memory where they are declared, but reference types hold a refernce to an object in memory
    
     * value type are destroyed immediately after the scope is lost, where as for ref types only the refence variable is destroyed after the scope is lost. 
     The object is lated destroyes by garbage collector
     
     * when you copy a stuct into another struct, a new copy of that struct gets created and modifications on one struct will not affect the values contained
     by other stucts
     
     when you copy a class into another class, we only get a copy of refernce variable. Both the reference variables point to the same object on the
     heap. so operations on one will affect the values contained by other reference variable.
     
     Structs can't have distructores but class can have a distuctors
     
     Struct can not have explicit parameters less constuctos where as class can 
     
     Stuct can not inherit from another class where as class can, both structs and classes can inherit from interfacese.
     Examples of structs in the .net frame work - int(System.int32), double(system.double) etc.
    
     * Note1: A class or a stuct cannot inherit from another stuct. stuct are sealed type . we can also have sealed class for example
     * public sealed Customer which can not be parent class of any class and no class can inherit from sealed class. This is how you can prevent 
     * a class from being inherited
     
     Note2:: How do you prevent a class from being inherited? or what is the significance of sealed key word? */
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; /*the scope of this variable is the entire main method*/
            
            //c1 is a reference variable which is stored on the stack where are values of c1 will be in the memory
            if (i == 10)
            {
                int j = 20; // j variable is destroyed as soon as the scope of id condition ends.
                Customer C1 = new Customer(); /*scope of C1 also is upto end of if condition where as the value associated with it resides in 
                                               heap. The value would be deleted by grabage collector latter on if it is called.*/
                C1.Id = 101;
                C1.Name = "Customer 1";
            }
           /*copying one structore to another since ints are also stuctures*/
            int structure1 = 10;
            int stucture2 = structure1;
            stucture2 = stucture2 + structure1;
            /*since they are value type the value of stucture2 doens't efffect value of stucture1*/
            System.Console.WriteLine("Value type : " + stucture2);
            /*now lets see reference type*/
            Customer C2 = new Customer();
            C2.Id = 102;
            C2.Name = "Customer 2";
            /*copying reference variable so they end up pointing at same memory. so operations on c3 will effect c2 and values on c2 will effect c3*/
            Customer C3 = C2; /*if customer is a stuct this would work because stuctures have different copies. */
            System.Console.WriteLine("Reference Type C3: " + C3.Name + " & " + C3.Id);
            C3.Id = 103;
            C3.Name = "Customer 3";
            System.Console.WriteLine("Reference Type C3 : "+C3.Name+ " & " +C3.Id);
            System.Console.WriteLine("Reference Type C2 : " + C2.Name + " & " + C2.Id);
            System.Console.WriteLine("Reference Type C3 : " + C3.Name + " & " + C3.Id);
            System.Console.ReadLine();
        }
    }
    public class Customer
    {
        /* public stuct customer {
         * we can not have a parameter less constuctor i.e we can not have public Customer().
         * 
         }*/
        private int _id;
        private string _name;
        ~Customer()
        {

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void PrintDetails()
        {
            System.Console.WriteLine("Id = {0} & Name = {1]", this._id, this._name);
        }
    }
    }
 
