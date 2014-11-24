using System;
using AssemblyOne;


namespace AssemblyTwo
{
    public class AssemblyTwoClassOne
    {
        public void print()
        {
            AssemblyOneClassOne ASC1 = new AssemblyOneClassOne();
           /*you can not access internal members of AssemblyOneClassOne*/
            
        }
    }
    public class AssemblyTwoClassTwo : AssemblyOneClassOne
    {
        public void print(){
            AssemblyTwoClassTwo AS2C2 = new AssemblyTwoClassTwo();
            System.Console.WriteLine("Protected internal: " +AS2C2.protectedID);
        }

    }
}
