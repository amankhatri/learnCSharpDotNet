using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Partial_Classes
{
   public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
    }
}
