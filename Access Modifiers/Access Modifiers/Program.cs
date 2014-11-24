using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    /*In c sharps there are 5 difference access modifiers 
     1) Private
     2) Protected 
     3) Internal
     4) Protected Internal
     5) Public
     private members are available only with  in the containing type, where as public members are avaiable anywhere. There is no restriction.
     
     protected members are available with in the containing type and to the types that derive from the containing type.
    
     private : accesibility : Only within the containing class
     Public : Accesibility Anywhere, no restrictions
     Protected: Accesibility; With in the containing types and the types derived from the contraining type*/

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 10;
            System.Console.WriteLine("ID = " + c1.ID);
            System.Console.ReadLine();
        }
    }
    public class Customer
    {
        #region Fields
        private int _id; //this private id field is avaible only in the class containing this field which is customer
        protected int ID1; //this is not acceable in main method this is only acceable to child class or the classes which are derived from customer 
        //class 
        #endregion
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
    public class CorporateCustomer : Customer
    {
        
        public void printID1()
        {
            /*since id is an instance field we need to create an object of derived class.*/
            CorporateCustomer cc = new CorporateCustomer();
             cc.ID1 = 10;
        }
    }
}
