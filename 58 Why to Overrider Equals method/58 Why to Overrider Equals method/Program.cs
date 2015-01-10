using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Why_to_Overrider_Equals_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;
            /*customer is the object it self*/
            Customer c1 = new Customer();
            c1.FirstName = "Simon";
            c1.LastName = "Tan";
            /*c2 and c2 are object refernce variables which recide on stack */
            Customer c2 = c1;
            /*c3 is pointing to diffferent object on the heap.*/
            Customer c3 = new Customer();
            c3.FirstName = "Simon";
            c3.LastName = "Tan";
            System.Console.WriteLine(i==j);
            System.Console.WriteLine(i.Equals(j));
            /*Equals methods checks the equality of values, it is declared as public virtual bool equals(object obj) . because of virtual keyword
             this method is open for overriding. for value types we dont really need to override methods. */
            /*we can also compair enumbes using enum because they are valule types*/
            System.Console.WriteLine(direction1==direction2);
            System.Console.WriteLine(direction1.Equals(direction2));
            /*Since references c1 and c2 are pointing to same object then they are equal so the statement below returns true because there values are 
             * equal too. if you perform operation on one object reference it will also change the second object reference.*/
            System.Console.WriteLine(c1 == c2);
            System.Console.WriteLine(c1.Equals(c2));
            /*if value is true and references are not s*/
            /*Refernce equality*/
             System.Console.WriteLine(c3 == c1); //returns false
            /*Valule equality*/
            System.Console.WriteLine(c3.Equals(c1)); // returns false before overriding.
            /*while overriding a method we should also override the hash code for a method.*/
        }
    }
    /*enums are value types*/
    public enum Direction
    {
        East  = 1,
        West = 2,
        North = 3,
        South = 4,
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            /*we have to make sure that the object is of same type, that is the objects should be customer, or any other inherited type*/
            if (obj == null) { return false; }
            /*so if the obj is not cutomer type or is not an object which inherits from customer then return false*/
            if (!(obj is Customer)) { return false; }
            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }
        public override int GetHashCode()
        {
            /*return the hash code of first and last name, ^ represents with*/
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
