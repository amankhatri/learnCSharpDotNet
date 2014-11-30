using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    /*Attributes allow you to add declarative information to your programs. This information can then be retrieved at runtime using reflection.
     There are several pre-defined attributes provided by .NET . it is also prossible to create your own custom attributes
     A few pre-defined attributes with in the .NET framework:
     Obselete : Marks types and type members outdated
     WebMethod: To expose a method as an XML webservice method
     Serializable: Indicates that a class can be serialized
     It  is possible to customize the attribute using parameters
     An aattribute is a class that inherits from System.Attribute base class.*/
    class Program
    {
        static void Main(string[] args)
        {
            /*This method uses the old method to add however if we make a new method to add as many numbers as given , we need to change old meathods*/
            Calculator.Add(10, 20);
            Calculator.Add(new List<int>() {10,20,30,40});
        }
    }
    public class Calculator
    {
        [ObsoleteAttribute("Use Add(List<int>Number) Method") /*This is what tells us that this method is obselete*/
        /*you can also do  [Obsolete("Use Add(List<int>Number) Method"] you can customize Oboliete Class 
          annd theow an error by doing ObsoleteAttribute("Use Add(List<int>Number) Method",true)*/
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int Add(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            return FirstNumber + SecondNumber + ThirdNumber;
        }
        /*New Method*/
        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int number in Numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
    }
}
