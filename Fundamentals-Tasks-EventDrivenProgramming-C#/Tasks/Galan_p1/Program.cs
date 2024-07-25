using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galan_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---init---
            string name,course;
            double prelim,mid,final;
            Console.Write("Laboratory Activity 1\n\n");
            Console.Write("Enter Your Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Your Course : ");
            course = Console.ReadLine();
            Console.Write("Prelim Grade 30% : ");
            prelim = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prelim Grade 30% : ");
            mid = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prelim Grade 30% : ");
            final = Convert.ToDouble(Console.ReadLine());

            // multiplying the percentage of every term
            double pre = prelim * .30;
            double midterm = mid * .30;
            double fin = final * .40;
            
            //getting the final subject grade
            //with decimal
            double total = pre + midterm + fin;

            //displaying the result
            Console.WriteLine("\n=======================\n======= Result ========\n=======================\n\nStudent Name : " + name+" - "+course.ToUpper()+"\nSubject Grade : "+ Convert.ToString(total));
            Console.ReadKey();

        }
    }
}
