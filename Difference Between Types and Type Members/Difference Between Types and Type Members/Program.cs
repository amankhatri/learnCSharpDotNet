using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Between_Types_and_Type_Members
{
    /*In this example customer is type and fields, properties and method are type member 
     so in general classes , structs, enums, interfaces, delegates are called as types and
     field, properties, constructors, emthods etc. that normally reside in a type are called as type members
     in c sharp there are 5 different access modifiers:
     1) Private
     2) Protected
     3) Internal 
     4) Prtected Internal
     5) Public
     Type members can have all the access modifiers, where as types can have only 2 (internal, public) of the 5 access modifiers
     Note: Using refions you can expand and collapse sections of your code either manually or using visual studio Edit->outlining->toggle all outlining
      you cant have access modifiers in front of enums*/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Customer
    {
        #region Fields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id;}
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion
        #region Methods
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
        #endregion
    }
}
