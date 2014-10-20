using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implicit conversion is done by compiler: 
             1) When there is no loss of information if the conversion is done
             2) If there is no possibility of throwing exceptions during the conversion
             Example Converting an int to a float will nt loose any data and no exception will be thrown, hence an implicit conversion can be done. 
             Where as when converting a float to an int, we loose the fractional part and also a possibility of  overflow exception. Hence in this case
             an explicit conversion is required. For explicit conversion we can use cast operator or the convert class in c sharp*/
            
            /*Conversion using Cast operators. If we try to covert float nnumber which is more than the range of integer. it will not give any error
             * and it would just wrap around*/
            float f1 = 123.45F;
            int i1 = (int)f1;
            /*Conversion using convert class.  If we try to covert float nnumber which is more than the range of integer. it will give an error
             * and it would would not wrap around*/
            float f2 = 123.45F;
            int i2 = Convert.ToInt32(f2);
            /*If the number is in a string format you have 2 options:
             1) using Parse() 
             2) using TryParse()*/
            /*Parse() method throws an exceptio if it cannot parse the value, whereas TryParse() returns a bool indicating whether i succeeded
             or failed*/
            /*Use Parse() if you are sure that the value will be valid other vise use TryParse()*/
            /*Example of using just parse method*/
            string strNumber1 = "100";
            int i3 = int.Parse(strNumber1);
            System.Console.WriteLine("String Number is: " +i3);
            /*Example of using TryParse()*/
            string strNumber2 = "100TG";
            int i4;
            bool isConversionSuccessful = int.TryParse(strNumber2,out i4); //TryParse(stringToBeConverted, output_parameter) and returns bool
            if (isConversionSuccessful)
            {
                System.Console.WriteLine("Successfully Converted string is : " + i4);
            }
            else
            {
                System.Console.WriteLine("Conversion Not Successful");
            }
            System.Console.ReadLine();

        }
    }
}
