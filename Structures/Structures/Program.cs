using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    /*just like classes structs can have 1) private fields, 2) public properties , 3) constructors and4) methods.. There are several
     differences between classes and structs. Object initilizer syntax can be used to initialize either a struct or a class.*/
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Customer1"); /*same as for class*/
            C1.PrintDetails();
            System.Console.ReadLine();
            /* syntax*/
            Customer C2 = new Customer(); // you can't do this in class where as structs would let you have this default constructors
            C2.PrintDetails(); // id = 0 and name = blank here
            C2.Id = 102;
            C2.Name = "Customer2";
            /*Object initializer syntanx*/
            Customer C3 = new Customer
            {
                Id = 103,
                Name = "Customer3"
            };
            C3.PrintDetails();

        }
    }
    public struct Customer
    {
        private int _id;
        private string _name;

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
        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetails()
        {
            System.Console.WriteLine("Id = {0} & Name = {1]", this._id, this._name);
        }
    }
}
