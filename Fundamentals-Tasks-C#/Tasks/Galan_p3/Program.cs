using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galan_p3
{
    internal class Program
    {
        static void Main(string[] args)
        {   //---MAIN---
            print("\n\t\tPROJECT 3\nConverts seconds into hours, minutes, and seconds \n\nName : Galan, Mark Francis N.\n\n");
            //getting the time from given seconds
            //--init
            int the_seconds,hour, mins, sec;

            print("Enter Value of Seconds : ");
            the_seconds = Convert.ToInt32(Console.ReadLine());
            //there are 3600 seconds in 1 hour
            //input number 5000

            hour = the_seconds / seconds_in_onehour();
            int remaining_seconds = the_seconds % 3600;  // using the modulo operation to get the remaining seconds after get the hour/s
            mins = remaining_seconds / 60;
            sec = remaining_seconds % 60;  // using the modulo operation to get the remaining seconds after get the minute/s

            //the output should be  1 hour 23 minutes 20 seconds
            print(Convert.ToString("\nResult of Conversion\n"+hour +" hour/s\n" + mins + " minute/s\n"+ sec +" second/s"));
            Console.ReadKey();
        }
        static int seconds_in_onehour()
        {
            
            int mins_in_anhour = 60;
            int second_in_onemins = 60;
            int seconds_in_anhour = mins_in_anhour* second_in_onemins;
            return seconds_in_anhour;
        }
        static void print(string s)
        {
            // a method to print the output string datatype <<
            Console.Write(s);
        }
    }
}
