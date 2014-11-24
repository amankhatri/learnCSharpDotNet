using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClassOne
    {
        /*If it were public it would be accessable everywithere, but since this is internal this method will be accessable everwhere in this assembly
         you can not access it in AssemblyTwo*/
        internal int ID = 101;
        protected internal int protectedID = 102;
    }
    public class AssembleOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClassOne assemblyOneClass1 = new AssemblyOneClassOne();
            System.Console.WriteLine(assemblyOneClass1.ID);

        }
    }
}
