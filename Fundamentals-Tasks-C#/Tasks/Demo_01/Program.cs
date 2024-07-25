using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


//Static method and non-static
//non-static can't execute in static main
//Program p1 = new Program(); // instantiatiorq



namespace Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            show();
            show("sdca");
            show(20);

            //MainProgram mp1= new MainProgram();
            //mp1.talk();
            Program p1 = new Program(); // instantiatiorq
            p1.hello(); //hello method
            Console.ReadKey();
        }

       
    
        
        //METHOD OVERLOADING----------------//
        void hello()
        {
            Console.WriteLine("Hello this is from method hello()");
            //Empty
        }
        static void  show()
        {
            Console.WriteLine("Hello this is from method show()");
            //Empty
        }

        //has parameter
        static void show(string name)
        {
            //String
        }
        static void show(int count)
        {
            //Integer
        }
        static void show(string name, int count)
        {
            //String and Integer
        }
        //METHOD OVERLOADING----------------//
    }
}
