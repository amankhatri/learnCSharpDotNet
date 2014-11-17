using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*The InnerException property returns the exception instance that caused the current exception.
 To Return the original exception pass it as a parameter to the constructor , of current exception.
 Always check if inner exception is not null before accessing any property of the inner
 exception object, else , you mayu get null reference exceptio. 
 To get the type of inner exception use getType() method*/
namespace Inner_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    System.Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(System.Console.ReadLine());
                    int Result = FN / SN;
                    System.Console.WriteLine("Result = {0}", Result);

                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Sample Files\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.Close();
                        System.Console.WriteLine("There is a problem, please try later");

                    }
                    else
                    {
                        /*if we want to intentionally throw an expceion we use throw keyword*/
                        /*we are also throwing the original exeption ex with the new expcetion which is thrown in case file is not found*/
                        throw new FileNotFoundException(filePath + "is not present {0}", ex);

                    }

                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine("Current Exception " + exception.GetType().Name);
                if (exception.InnerException != null)
                /*Always check if inner exception is not null before accessing any property of the inner
                    exception object, else , you mayu get null reference exception. */
                {
                    System.Console.WriteLine("Inner Exception " + exception.InnerException.GetType().Name);
                }
            }
            finally
            {
                System.Console.ReadLine();
            }
            
           
            
        }
    }
}
