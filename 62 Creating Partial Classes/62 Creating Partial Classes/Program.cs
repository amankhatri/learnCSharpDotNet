using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Creating_Partial_Classes
{
    /*1) All the parts spread across different files must use the partial keywords.
     2) All the parts spread across different files, must have the same access modifiers, that is we can either have public or internal. 
     3) If any of the parts are declared abstract, then the entire type is considered abstract.
     4) if any of the parts are declared sealed, then the entire type is considered sealed. (Sealed means no class can inherit from a sealed class
     5) If any of the parts inherit a class, then the entire type inherits that class.
     6) C# doesnt nsupport multiple class inheritance. Different parts of the partial class, must not specify different base classes.
     7) Different parts of the partial class can specify different base interfaces, and the final type implementas all of the interfaces listed by all
     the interfaces listed by all of the partial declaration.
     8) Any memebers that are declared in a partial definition are available to all of the other parts of the partial class.*/
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
