using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _61_Partial_Classes; 

namespace _61_Partial_Classes
{
    public partial class PartialCustomer
    {
        public string GetFullName() { return _firstName + "," + _lastName; } 

    }
}
