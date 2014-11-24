using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_2
{
    /*Internal and Protected Internal
     A member with internal access modifier is avaible anywhere with in the containing assembly. It's a pile time error to access, an internal 
     member from outside the containing assembly
     Protected Internal members can be accessed by any code in the assemly in which it is declared , or from within a dferived class in another 
     assembly. It is a combination of protected an internal if you have understod protected an internal , this should be very easy to follow. 
     * Classes can be drived from classes in another assembly
     Access Modifier: Internal : Accesibilty : Anywhere within the containing assembly
     Access Modifer: Protected Internal : Accessibiity: Anywhere with in the containing assembly, and from within a derieved class in any other
     assembly*/
    /*In dot net when you compile a project an assembnly is created. Assemblies in dot net are of two types: EXEs and DLLs. Windows applications 
     generate EXEs and a class compliation or the web application generates DLLs. Console application generates EXE files. These files contains
     intermediate laguage it contains classes fields method etcs
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
