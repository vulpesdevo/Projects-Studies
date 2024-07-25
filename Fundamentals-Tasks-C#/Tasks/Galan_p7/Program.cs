using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galan_p7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string name, gender;
            int num;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Gender : ");
            gender = Console.ReadLine();
            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nResult\n"+genderB_or_G(name, gender.ToLower()));
            Count(name, num);
            Console.ReadKey();
        }
        public static string genderB_or_G(string n,string g )
        {
            if (g == "male")
            {
                return "Boy";
            }
            else
            {
                return "Girl";
            }
        }
        static void Count(string n, int countnumber)
        {
            for (int i = 0;i< countnumber; i++)
            {
                Console.Write(n + " ");
            }
        }
    }
}
