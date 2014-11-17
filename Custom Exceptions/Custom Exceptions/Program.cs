using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace Custom_Exceptions
{
    /*When do you usually go for creating your own custom exceptoions
     that is because all the default application may not be adequate do describe problem.
     Example
     1) I have an asp.net we application, the application should alllow the user to have only one logged in session.
     if the user is already logged in and if he opens another browser window and tries to login again, the application
     should throw an error stating he is already logged in another browser window.
     Within the .NET framework we don't have any exception, that adequately describes this problem. so this scenario 
     is one of the examples where you want to create a custom exception.*/
   /*when one application talks to another application the objects must be able to talk to each other and you want your
    classes to be serializable*/

    /*Create a ckass that derives from System.Exception class. As a convention , end the class name with  Exception suffix. All . net
     exceptions end with, exception suffix.
     2) Provide a public constructor, that takes in a string parameter . The constructor simply [asses the string paraeter, to the base
     exception class constructor.
     3) Using InnerExceptions, you can also track back the original exception. if you want to provide this capabililty for your custom exception class,
     then overload the constructor accordingly
     4) If you want your exception class object to work across application domains, then the object must be serializable . To make your exception
     serializable mark it with serialzable attribute and provide a constructor that invokes the base exception class constructor 
     that takes in serializationInfo and StreamingContext Objects as parameters
     Note: It is also possible to provide your own custom serialzation which will discuss in a later session*/
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            }
            catch (UserAlreadyLoggedInException uexp)
            {
                System.Console.WriteLine(uexp.Message);
            }
            
            System.Console.ReadLine();
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        /*Constuctor overloading from base class*/
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {
        }
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

    }
}
