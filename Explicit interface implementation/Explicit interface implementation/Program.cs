using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_interface_implementation
{
    
    interface I1
    {
        void InterfaceMethod(); //explicit interface can not have access method
    }
    interface I2
    {
        void InterfaceMethod(); //explicit interface can not have access method
    }
    
    
    class Program : I1, I2
    {

        static void Main(string[] args)
        {
            Program P1 = new Program();
            ((I1)P1).InterfaceMethod();
            ((I2)P1).InterfaceMethod();
            /*you can also do this:*/
            I1 i1 = new Program();
            I2 i2 = new Program();
            i1.InterfaceMethod();
            i2.InterfaceMethod();
            /*if you want to make InterfaceMethod(); from one of the interfaces to be default then you call interfacemethod which you want to make as
             default like this:*/
            P1.InterfaceMethod();
            /*where as non default method should be called explicityly*/
            System.Console.ReadLine();
           
        }
        /*dot net is thinking that you have implemented the methods from both the classes. Since we cannot distingh beween I1 and I2 which is called
         * to impelement InterfaceMethod(). To distinguish between the interfaces with same methods we use explicit interfaces*/
         public void InterfaceMethod() //explicit interface do not have access modifiers. 
        {
            System.Console.WriteLine("I1 Interface Method");
        }
        /*Explicity interfaces do not have access modifiers 
         * and you have to use interface name .method name*/
        void I1.InterfaceMethod() //explicit interface do not have access modifiers. 
        {
            System.Console.WriteLine("I1 Interface Method");
        }
        void I2.InterfaceMethod() //explicit interface do not have access modifiers. 
        {
            System.Console.WriteLine("I2 Interface Method");
        }
    }
}
