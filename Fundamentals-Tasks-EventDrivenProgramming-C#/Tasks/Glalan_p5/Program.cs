using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galan_p5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print("\n\t\tPROJECT 5\nGetting the Total Amount \nincluding and excluding the 25% VAT\n\nName : Galan, Mark Francis N.\n\n");

            string _divider_ = new string('-', 42);
            double _unit_price, _amt_exc_vat, _vat = .25, _total;
            int _quantity;
            print("Enter the Unit Price : ");
            _unit_price = Convert.ToDouble(Console.ReadLine());
            print("Enter the Quantity : ");
            _quantity = Convert.ToInt32(Console.ReadLine());


            _amt_exc_vat = _unit_price * _quantity;
            _vat *= _amt_exc_vat;
            _total = _amt_exc_vat + _vat;

            print("\n\t\t\t\t  |   OUTPUT\n"+ _divider_ + "\nTotal Amount Excluding VAT(25%)   |   " + _amt_exc_vat + "\n"+ _divider_ + "\nVAT 25%  \t\t\t  |   " + _vat + "\n"+ _divider_ + "\nTotal Amount Including VAT(25%)   |   " + _total);

            Console.ReadKey();
        }
        static void print(string s)
        {
            // a method to print the output string datatype <<
            Console.Write(s);
        }
    }
}
