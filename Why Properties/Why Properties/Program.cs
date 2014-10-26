using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_Properties
{
    class Program
    {/*marking the class field public and exposing to the external world is bad, as you will not have control over what gets assignment and returns. 
      */
        /*Buisness statements says no body should be able to change student id and pass marks however if we make them public they are visible 
         * to the entire world and any body can change it. The programing languages that doesnot have properties use getter and setter methods 
         to encapsulate and protect fields. In this example we use the SetId(int id) and GetId() methods to encapsulate_id class field. In c sharp
         * we have properties so we don't have to use getter and setters. As a result
         we hva better control on what gets assigned and returned from the _id fields*/
        static void Main(string[] args)
        {
            Student1 C1 = new Student1();
            C1.ID = -101;
            C1.Name = null;
            C1.PassMark = 0;
            System.Console.WriteLine( "id: {0} & name: {1} & Passmark: {2}",C1.ID,C1.Name,C1.PassMark);
            Student2 C2 = new Student2();
            C2.SetId(100);
            System.Console.WriteLine("Student ID" +C2.GetId());
            System.Console.ReadLine();
        }
    }
    public class Student1
    {
        public int ID;
        public string Name;
        public int PassMark = 35;
    }
    /*student 2 demostrate getters and setters*/
    public class Student2
    {
        /*by convention we declare the names of the private variables start with _ underscore for example private int _id*/
        private int _id;
        private string _name;
        private int _passMark = 35;
        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Sutdent Id can not be negative");
            }
            this._id = id;
        }
        public int GetId()
        {
            return this._id;
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name Cannot be Null");
            }
            this._name = name;
        }
        public string GetName()
        {
            /*if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            return this._name;
        }*/
            /*tarnary operators if condition*/
            return string.IsNullOrEmpty(this._name) ? "No Name " : this._name;
        }
        public int GetPassMark()
        {
            return this._passMark; // and since we don't have a setter for pass mark no body in external world would be able to change _passMark variable
        }
    }
}
