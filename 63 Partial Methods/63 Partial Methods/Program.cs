using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_Partial_Methods
{
    class Program
    {
        /*if a partial method doesn't have a defination the compiler ignores it.*/
        /*1) Partial class or a struct can contain partial methods.
         2) A paartial method is created using partial keyword
         3) A partial method declaration consists of two parts
            3a) The definition (Only the method signature)
            3b) The implementation.
            The maybe in separate parts of a partial class, or in the same part.
         4) The implementation for a partial method is option. If we don't provide the implementation, the compiler removes the signature and 
         * all calls to the method.
         5) Partial methods are private by default, and it is a compile time error to include any access modifies , including private.
         6)  It is a compile time error, to include declaration and implementation at the same time for a partial method.
         7) A partial method return type must be void. Including any other return type is a compile time error.*/
        static void Main(string[] args)
        {
            SamplePartialClass SPC = new SamplePartialClass();
            SPC.PublicMethod();
        }
    }
}
