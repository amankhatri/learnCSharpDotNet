using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_Partial_Methods
{
     public partial class SamplePartialClass
    {
        partial void SamplePartialMethod()
        {
            System.Console.WriteLine("SamplePartialMethod");
        }
    }
}
