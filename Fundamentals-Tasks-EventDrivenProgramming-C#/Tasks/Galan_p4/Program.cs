using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galan_p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList arrayList = new ArrayList() { };
            print("\n\t\tPROJECT 4\nGetting the Perimeter and Area of the Circle \n\nName : Galan, Mark Francis N.\n\n");
            string _divider_ = new string('-', 40); 
            int N;
            double _the_pi_ = Math.PI, _perimeter_,  _sqrd_radius_;

            print("Enter Radius : ");
            N = Convert.ToInt32(Console.ReadLine());


            _perimeter_ = 2 * N * _the_pi_; // the perimeter
            _sqrd_radius_ = Math.Pow(N, 2);
            _sqrd_radius_ *= _the_pi_; //the AREA

            //  OUTPUT
            print("\nPerimeter : "+_perimeter_ + " or " + Math.Round(_perimeter_, 2) + "\n"+_divider_+"\nArea\t  : " + _sqrd_radius_+" or "+ Math.Round(_sqrd_radius_,2)); 

            Console.ReadKey();
        }
        static void print(string s)
        {
            // a method to print the output string datatype <<
            Console.Write(s);
        }
        
    }
}
