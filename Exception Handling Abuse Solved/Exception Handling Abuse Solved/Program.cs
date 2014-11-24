using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Abuse_Solved
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Please Enter Numerator");
                int Numerator;
                int Denominator;
                int Result;
                /*Try parse returns true or false. */
                bool IsNumberatorConversionSuccessful = Int32.TryParse(System.Console.ReadLine(), out Numerator);
                if (IsNumberatorConversionSuccessful)
                {
                    System.Console.WriteLine("Please Enter Denominator");
                    bool IsDenominatorConversionSuccessful = Int32.TryParse(System.Console.ReadLine(), out Denominator);
                    if(IsDenominatorConversionSuccessful && Denominator!=0)
                    {
                        Result = Numerator / Denominator;
                    }
                    else if(Denominator == 0)
                    {
                        System.Console.WriteLine("The Denominator should not be zero");
                    }
                    else
                    {
                        System.Console.WriteLine("Denominator should be in range {0} to {1} ", Int32.MinValue, Int32.MaxValue);
                    }
                }
                else
                {
                    System.Console.WriteLine("Numerator should be in range {0} to {1}", Int32.MinValue, Int32.MaxValue);
                }
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
