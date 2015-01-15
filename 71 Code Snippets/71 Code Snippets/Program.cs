using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_Code_Snippets
{
    /*Code Snippets are ready made snippets of you can quickly insert into your code.
     1) Keyboard shortcut: ctrlK + x;
     2) Right Click and select "Insert snippet..", from the context menu
     3) Click on Edit - Intellisense - Insert Snippet
     4) Use code snippets short cut. For example to use "For loop" code snippet type "for" and TAB key twice.
     
     Once a code snippet is inserted, the editable field are highlighted in yellow, and the first eaditable field is selected automatically. Upon 
     changing the first editable field, press TAB to nmove to the next editable field. To come to the previous editable field use SHIFT+TAB. Press Enter 
     or ESC keys to cancel field editing and return the code editor to normal.
     
     Code Snippet Types:
     Expansion: These snippets allows the code snippet to be inserted at the cursor.
     SurrondsWith: Thse snippets allows the code snippet to be placed around a selected piece of code
     Refactoring: THese snippets are used during code refactoring,*/
    class Program
    {
        static void Main(string[] args)
        {
            int length = 2;
            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine("Auto Generated");
            }
        }
    }
}
