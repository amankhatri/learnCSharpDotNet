using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Instance_Class_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            System.Console.WriteLine("Area 1 of Circle is " + C1.CalculateArea());
            Circle C2 = new Circle(6);
            System.Console.WriteLine("Area 1 of Circle is " + C2.CalculateArea());
            Circle.PrintArea();
        }
    }
    class Circle
    {
        /*Since the value of pi doesn't change regard less of how many objects you create we should declare it as static. If we don't put static 
         key word in front of things which belong to class and are same for all objects then they are static or non instance feilds. When a member is 
         a static member, like pi, its value remains constant between all the objects unlike the value of instance variable Radius. Static variables
         are share with all the objects where as instance variables have different values for each object. Static variable makes the program efficient
         because it uses less memory since there is only one copy of _PI for each object.*/
        static float _PI;
        int _Radius;
        /*if there is no access modifier in front of a method or a class by default it is declared as private and you can only access those class members 
         in that specific class*/
        /*A static constructor need not be called anytime, it will be called automatically to refer to static variables. Static Constructor is used
         to initialize static variables of a class or to initialize static members of a class. static constuctors are classed before instance constructors
         and any other instatnce methods and even before referring to any static fields. Static constructor is only called once regardless of how ever
         many instances you create. Static constructor is always called before anything in a class in the main method, this happens automatically.*/
        static Circle()
        {
            _PI = 3.141f;
        }
        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            /*The moment i declare _PI as static variable, I can't refer _PI by typing this. (this._PI * this._Radius * this._Radius. Because this does
             * change on per object basis, instead of using this._PI we should use className._PI. Methods can also be static).  */
            return (Circle._PI * this._Radius * this._Radius);
        }
        public static void PrintArea()
        {
            /*you cant have non static member or an instance member in static method*/
            System.Console.WriteLine("Area");
        }
    }
}
