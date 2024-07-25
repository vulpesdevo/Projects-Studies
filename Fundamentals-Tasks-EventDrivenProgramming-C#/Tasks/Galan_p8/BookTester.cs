using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galan_p8
{
    internal class BookTester
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book(200,"Java Programming", "Steven Jones",30);
            b1.printBook();
            Console.WriteLine("Book ID : "+b2.getBookId());
            Console.WriteLine("Book Name : " + b2.getBookName());
            Console.WriteLine("Book Author : " + b2.getBookAuthor());
            Console.WriteLine("Book Quantity : " + b2.getBookQuantity());

            Console.ReadKey();
        }
    }
}
