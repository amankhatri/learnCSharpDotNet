using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_Partial_Methods
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();
        /* we can also declare the function here.
                 partial void SamplePartialMethod()
        {
            System.Console.WriteLine("SamplePartialMethod");
        }*/
        public void PublicMethod()
        {
            System.Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
