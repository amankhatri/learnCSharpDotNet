using System;
using System.IO;
/*An Exception is an unforessen error that occurs when a program is running
    Exaples:
    Trying to read from a file that does not exist , throws FileNotFoundException.
    Trying to read from a database table that does not exist, thows a sqlException.
   
 Showing actual unhandled exceptions to the end user is bad for two reasons
    1) Users will be annoyed as they are cryptic and does not make much sense to the end users.
    2) Exceptions contain informatin that can be used for hacking into your application
 
 An exception is actually a class that derives from System.Exception class. The System.Exception a class that derives from 
 System.Exception class has several userful properties that provide valuable information about the exception.
 
 Message: Gets a message that describes the current exception
 Stack Trace: Provides the call stack to the line number in the method ewhere the exception occured. */
namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Sample Files\Data.txt");
                System.Console.WriteLine(streamReader.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("Please Check if the file exists");
                System.Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            /*if there is an error inside a catch block the program will be stuck inside the catch block and the codition which is not in the
             finally block will never be excuted, so always use finally block*/
            finally
            {
                //if there is a error in opening the file there would be error in closing the file so we need to check if stream reader is not equal
                //to null
                if(streamReader!= null)
                {
                          streamReader.Close();
                }
          
            }
            

            System.Console.ReadLine();
        }
    }
}
