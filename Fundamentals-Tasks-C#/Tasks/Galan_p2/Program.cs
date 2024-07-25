using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galan_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //.....MAIN.....
            // counting the time of person's existence
            //---init--

            int age, months, days, hours, minutes;

            print("\tPROJECT 2\n\tEXISTENCE\nName : Galan, Mark Francis N.\n\n");
            //asking the user to input age in number form like 1,2,3
            print("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            // the computation
            months = age * 12;
            days = age * 365;
            hours = days * 24;
            minutes = hours * 60;

            //the output with the print() method
            print("\nOutput:\nMonths Exist : " + months.ToString());
            print("\nDays Exist : " + days.ToString());
            print("\nHours Exist : " + hours.ToString());
            print("\nMinutes Exist : " + minutes.ToString());
            Console.ReadKey();

        }
        static void print(string s)
        {
            // a method to print the output = string<<
            Console.Write(s); 
        }
    }
}
