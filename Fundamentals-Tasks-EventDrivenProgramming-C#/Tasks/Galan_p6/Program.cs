using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
      
namespace Galan_p6
{
    internal class Program
    {
        public static double _rate_perday = 0;
        public static bool isTrue = true;
        static void Main(string[] args)
        {
            string _divider_ = new string('*', 50);
            string _name="", _department="", _position = "";
            double _overtime=0, _grosspay,_tax;
            int _days_worked = 0;
            List<string> departmentList = new List<string>
            {
                "engineering","it"
            };
            List<string> _position_inDep = new List<string>
            {
                "staff","manager","supervisor","technician","programmer",
            };
            bool is_dep_pos = true;
            while (is_dep_pos)
            {
                print("Enter Employee Name : ");
                _name = Console.ReadLine();
                print("Department : ");
                _department = Console.ReadLine();
                print("Position : ");
                _position = Console.ReadLine().ToLower();
                print("Days Worked : ");
                _days_worked = Convert.ToInt32(Console.ReadLine());
                print("Overtime Hrs: ");
                _overtime = Convert.ToInt32(Console.ReadLine());
                if (departmentList.Contains(_department.ToLower()) && _position_inDep.Contains(_position))
                {
                    get_details(_department, _position);
                    is_dep_pos=false;
                }
                else
                {
                    print($"\n{_department} or {_position} does not exist\n\n");
                    is_dep_pos = true;
                }
            }
            
                
            
            
            
            if (isTrue == false) // if all the details are valid 
            {
                print($"\nEmployee Name : {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_name)} / {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_department)} / {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_position)}"); // Employee Name
                double _basicpay = _rate_perday * _days_worked;
                double eighthraday = _rate_perday / 8;
                
                _overtime *= eighthraday;          //Over Time
                _grosspay = _basicpay + _overtime; //Gross Pay
                _tax = _grosspay * .15;
                double netp = _grosspay - _tax;


                // using the ternary - concise way to express conditional logic in a single line 
                print($"\nBasic Pay : \t{(_basicpay % 1 == 0 ? _basicpay.ToString("N0") : _basicpay.ToString("N2"))}\nOvertime Pay : \t{(_overtime % 1 == 0 ? _overtime.ToString("N0") : _overtime.ToString("N2"))}\nGross Pay : \t{(_grosspay % 1 == 0 ? _grosspay.ToString("N0") :_grosspay.ToString("N2"))}\nTax 15% : \t{(_tax % 1 == 0 ? _tax.ToString("N0") : _tax.ToString("N2"))}\nNet Pay : \t{(netp% 1 == 0 ? netp.ToString("N0") : netp.ToString("N2"))}\n\n{_divider_}");
                
            }
            Console.ReadKey();

        }

        static void get_details(string department, string position)
        {

            switch (department.ToLower())
            {
                case "engineering":
                    switch (position)
                    {
                        case "staff":
                            _rate_perday = 800;
                            isTrue = false;
                            break;
                        case "supervisor":
                            _rate_perday = 1200;
                            isTrue = false;
                            break;
                        case "manager":
                            _rate_perday = 1800;
                            isTrue = false;
                            break;
     
                    }
                    isTrue = false;
                    break;
                case "it":

                    switch (position)
                    {
                        case "programmer":
                            _rate_perday = 1300;
                            isTrue = false;
                            break;
                        case "technician":
                            _rate_perday = 1000;
                            isTrue = false;
                            break;
                        
                    }
                    isTrue = false;
                    break;
               

            }
        }
        static void print(string s)
        {
            // a method to print the output string datatype <<
            Console.Write(s);
        }
    }
}
