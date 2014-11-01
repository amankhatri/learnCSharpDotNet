using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    /*A multicast delgate is a delegate that has references to more than one function. 
     * When you invoke a multicast delegate, all the functions the delegate is pointing to, are invoked.
     
     There are 2 approaches to create a multicast delegate. Dependingon the approach you use
     + or + = to register a method with the delegate
     - or - = to un register a method with the delegate
     Note: A multicast delegate , invokes the methods in the incovation llist, in the same order in which they are added. 
     
     if the delegate has a return type other than void and if the delegate is amulticast delegate, only the valule of the last invoked method
     * will be returned. Along the same lines, if the delegate has an out parameter, the value of the output parameter, will be the value assigned by
     * the last method.
     * 
     * Common intervie question - where do you use multicast delegates?
     * Multicast delegates makes implementation of observer design pattern very simple. Observer pattern is also called as publish/subscribe pattern.
     */
    public delegate void SampleDelegate();
    public delegate int SampleDelegateReturnValue();
    public delegate int SampleDelegateOutValue(out int value);
    class Program
    {
        static void Main(string[] args)
        {

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
          //del();
            /*Multicasting deligate approach
             * Poiting delgate to multiple functions*/
           /* SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);*/
            /*now del4 points to all three methods, so del4 is multi cast delegate*/
           /* del4 = del1 + del2 + del3; */
          /*  System.Console.WriteLine("adding delegates to chain");
            del4();*/
            /*you can also remove a delegate by doing this*/
          /*  System.Console.WriteLine("remove delegates to chain");
            del4 = del1 + del2 + del3 - del2;*/
            /*we can also do the same thing using different approach. */
            del += SampleMethodOne;
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del();
            /*Delgates maintain a list and it shows them in a way they were entered. */
            del -= SampleMethodTwo;
            del();
            /*returning values using delegates*/
            Console.WriteLine("Returning values using delegates");
            SampleDelegateReturnValue delValue = new SampleDelegateReturnValue(SampleMethodOneReturnValue);
            int delegateReturnValue = delValue();
            Console.WriteLine("Valule = " + delegateReturnValue);
            delValue += SampleMethodTwoReturnValue;
            delegateReturnValue = delValue(); //takes the value of last return from delegate
            Console.WriteLine("Valule = " + delegateReturnValue);
            System.Console.WriteLine("Using out parameter");
            SampleDelegateOutValue delValue2 = new SampleDelegateOutValue(SampleMethodOneOutValue);
            int outPut =  -1;
            int value =  delValue2(out outPut);
            Console.WriteLine("Value = " + value);
            delValue2 += SampleMethodTwoOutValue;
            value = delValue2(out outPut);
            System.Console.WriteLine("Value = " + value);
            System.Console.ReadLine();

           


        }
        public static void SampleMethodOne()
        {
            System.Console.WriteLine("Sample Methodone invoked");
        }
        public static void SampleMethodTwo()
        {
            System.Console.WriteLine("Sample MethodTwo invoked");
        }
        public static void SampleMethodThree()
        {
            System.Console.WriteLine("Sample MethodThree invoked");
        }
        public static int SampleMethodOneReturnValue()
        {
            System.Console.WriteLine("Sample SampleMethodOneReturnValue() invoked");
            return 1;
           
        }
        public static int SampleMethodTwoReturnValue()
        {
            System.Console.WriteLine("Sample SampleMethodTwoReturnValue() invoked");
            return 2;
        }

        public static int SampleMethodOneOutValue(out int number)
        {
            number = 1;
        }

        public static int SampleMethodTwoOutValue(out int number)
        {
            number = 2;
        }
    }
}
