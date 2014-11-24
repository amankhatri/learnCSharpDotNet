using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Abuse
{
    /*Exceptions are unforeseen erros that occr when a program is running. For example, when an application is executing a query, the
     database connection is lost. Exception handling is generally used to handle these scenarios.
     Using exception handling to implement program logical flow is bad and is termed as exceptional handling abuse*/
    class Program
    {
        static void Main(string[] args)
            /*instead of using so many try catch method, we should use checks at different places like we can use parsing instead of convert to method
             we can also check if denominator is zero. we should use less exceptions */
        {
            try
            {
                System.Console.WriteLine("Please Enter Numerator");
                int Numerator = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Please Enter Denominator");
                int Denominator = Convert.ToInt32(System.Console.ReadLine());
                int Result = Numerator / Denominator;
                System.Console.WriteLine("Result = {0} ", Result);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Please Enter a Number");
            }
            catch(OverflowException)
                //the number should be in range of int 32 bit
            {
                System.Console.WriteLine("Only numbers between {0} && {1} ", Int32.MinValue,Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Divide by Zero Exception");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                System.Console.ReadLine();
            }
        }
    }
}
