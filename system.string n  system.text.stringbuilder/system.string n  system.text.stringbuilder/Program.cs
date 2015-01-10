using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.string_n__system.text.stringbuilder
{
    class Program
    {
        /**/
        /*System.string is immutable*/

        /*StringBuilder is Mutable*/

        /*As string builder objects are mutable they offer better performance than string objects of type  system.string, when heavy string
         manupulation is involved*/
        static void Main(string[] args)
        {
            /*Immutable strings Steps:
             variables userstring gets created and it points to C#, 
             then we change userstring by adding video, a new object c# video is created and stored in userstring. However, the initial C#  will still
             be in the memory somehwere. So that is why it strings are immutable. These objects which are in heap stay there until garbage collector
             cleans it. They are no reference varable pointing to c# */
            string userString = "C#";
            /*we are changing the string object*/
            userString += " Video";
            userString += " Tutorial";
            userString += " for";
            userString += " Beginners";
            System.Console.WriteLine(userString);
            /*where as objects of stringbuilder is mutable and hence it doesn't waste heap on ophned string objects.*/
            StringBuilder userStringBuilder = new StringBuilder("C#");
            userStringBuilder.Append(" Video");
            userStringBuilder.Append(" Tutorial");
            userStringBuilder.Append(" For");
            userStringBuilder.Append(" Beginners");
            System.Console.WriteLine(userStringBuilder.ToString());
            /*if there is heavy string manupulation use string builder*/

        }
    }
}
