using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =10;
		    Program p = new Program();
		    /*Non static methods always require an object even if they are in the same class*/
		    p.evenNumbers1();
		    int sum = p.add(5,10);
		    /*you can directly call objects from same class if they are static*/
		    Program.evenNumbers2();
		    passByValue(i);
		    System.Console.WriteLine("i is: " +i);
             /*Now both of them will point to same memoy location ref1. Where as java is pass by value*/
            passByReference(ref i);
		    System.Console.WriteLine("i is: " +i);
	    }
         /*Method Definition 
	        [attributes]
	        access-modifiers return-type method-name(parameters)
            {
            	Method Body
            }*/
	    public void evenNumbers1() {
	    int start = 0;
	     while(start <=20)
		    {
			    System.Console.WriteLine(start);
			    start = start +2;
		    }
	    }
	    public static void evenNumbers2() 
        {
	        int start = 0;
	        while(start <=20)
		    {
			    System.Console.WriteLine(start);
			    start = start +2;
		    }
	    }
	    public int add(int firstNumber, int secondNumber)
        {
		    return firstNumber + secondNumber;
	    }
	    public static void passByValue(int j)
        {
		    j = 101;
	    }	
	    /*keyword ref, now j is ref paramenter so when we call the method in main 
        like this passByReference(ref i). Now both of them will point to same memoy location ref1.*/
	    public static void passByReference(ref int j)
        {
		    j = 101;
	    }	

        }
    }
