using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Example_2
{
    /*Enums
     If a program uses set of integral numbers, consider replacing them with enums, which makes the program more readable and maintainble
     1) Enums are enumerations
     2) Enums are strongly typed constants. Hence, an explicit cast is needed to convert from enum type to an integral type and vice versa. Also
     an enum of one type can not be implicitly assigned to an enum of another type even though the underlying value of their members are the same
     3) The default underlying type of an enum is int.
     4) The default value for first element is zero and gets incremented by 1.
     5) It s possible to customize the underlying type and values.
     6) Enums are value types.
     7) Enum keywod(all small letters ) is used to create enumerations, where as Enum class contrains static GetValues() and GetNames() methods
     which can be used to list Enum Underlying type values and Names.*/
    /*Enums are strongly typed constants because you cannot assign the any interger to enum to achieve this we have to do cast*/
    class Program
    {
        static void Main(string[] args)
        {
            /*Enums are strongly typed constants because you cannot assign the any interger to enum to achieve this we have to do cast*/
            Gender4 gender4 = (Gender4)3;
            int Num = (int)Gender4.Unknown; 
            /*You can;t do Gender gender = Season.Writer however since enums are strongly type constant so you would have to do */
            Gender4 gender5 = (Gender4)Season.Winter;
            /*you can get the values of enum you can do */
          int[] enumValue  =  (int[])Enum.GetValues(typeof(Gender1));
          string[] enumName = Enum.GetNames(typeof(Gender1));
          foreach (int value in enumValue)
          {
              System.Console.WriteLine("Values are " + value);
          }
          foreach (string name in enumName)
          {
              System.Console.WriteLine("Names are " + name);
          }
            /*we need to cast it to short*/
          short[] enumValue2 = (short[])Enum.GetValues(typeof(Gender2));
          enumName = Enum.GetNames(typeof(Gender2));
          foreach (int value in enumValue2)
          {
              System.Console.WriteLine("Values are " + value);
          }
          foreach (string name in enumName)
          {
              System.Console.WriteLine("Names are " + name);
          }
            /*Changing values*/
          enumValue2 = (short[])Enum.GetValues(typeof(Gender3));
          enumName = Enum.GetNames(typeof(Gender3)); //enum is a class which has Get names and get value methods
          foreach (int value in enumValue2)
          {
              System.Console.WriteLine("Values are " + value);
          }
          foreach (string name in enumName)
          {
              System.Console.WriteLine("Names are " + name);
          }
          System.Console.ReadLine();
        }
    }
    
    public enum Gender1 
    {
        /*This is default type of enum and the default values are numerical or integers which is default underling valules*/
        Unknown,
        Male,
        Female
    }
    public enum Gender2 : short /*now i have converted it to short so to convert and enum to a differt type you just put ":" and the name of the
                                 type you want to convert enum into*/
    {
        /*This is default type of enum and the default values are numerical or integers which is default underling valules*/
        Unknown,
        Male,
        Female
    }
    public enum Gender3 : short /*now i have converted it to short so to convert and enum to a differt type you just put ":" and the name of the
                                 type you want to convert enum into */
    {
        /*This is default type of enum and the default values are numerical or integers which is default underling valules. I can also assigned
         the values to these enums and they don't have to be in perticular order , however all the enums has to be in range of short*/
        Unknown = 5,
        Male =2,
        Female= 10
    }
    public enum Gender4 {

        Unknown = 1,
        Male =2,
        Female= 3
    }
    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    };
      
}
