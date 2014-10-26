using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    /*In c sharp to encapsulate and protect fields we use properties
     1) we use get and set accessors to implement properties
     2) A property with both get and set accessor is a Rea/Write Property
     3) A property with only get accessor is a Read Only property
     4) A property with only set accessor is Write Only Property
     The advantage of properties over traditional get and set methods is you can access them as if they were public properties.
     In c sharp you can implement properties automatically , because you may need not verify what you are setting or getting*/
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            /*when you call student1.Id it has value associated with it and in the method you refer to the value of student1.id as value */
            student1.Id = 100;
            System.Console.WriteLine("Get id :" + student1.Id);
            student1.Name = "First Last";
            student1.email = "firstlast@email.com";
            System.Console.WriteLine("Get id :" + student1.Name);
            System.Console.WriteLine("Pass Marks: " + student1.PassMark);
            System.Console.WriteLine("Email: " + student1.email);
                
            System.Console.ReadLine();
           
        }
    }
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        private string _city;
        
        public int Id
        {
            set
            {
                if(value<=0)
                {
                    throw new Exception("Id should be greater than zero");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Id should be greater than zero");
                }
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city= value;
            }
        }
        /*auto done, we don't even need to declare variables either, for example we need not create private string email variable 
         c sharp does it automatically for us. Auto implemented properties reduce the amount of code that we have to write
         When you use auto-implemented properties the compiler creates a private, anonymous field that can only be accessed through the propertys get
         * and set accessors*/
        public string email
        {
            get;
            set; 
        }
        
    }
}
