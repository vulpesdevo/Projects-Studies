using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Galan_p8
{
    internal class Book
    {
        //2
        public int id;
        public string name;
        public string author;
        public int quantity;

        //3
        public Book()
        {
            id = 0;
            quantity = 0;
            author = "Blank";
            name = "Blank";
        }
        
        //4
        public Book(int id, string name, string author, int quantity )
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.quantity = quantity;
        }

        //5
        public void setBook(int id, string name, string author, int quantity)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.quantity = quantity;

        }

        //6
        public void printBook()
        {
            Console.WriteLine("ID : "+id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Author :" + author);
            Console.WriteLine("Quantity : " + quantity);
        }

        //6
        public int getBookId()
        {
            return id;
        }
        //6
        public string getBookName()
        {
            return name;
        }
        //6
        public string getBookAuthor()
        {
            return author;
        }
        //6
        public int getBookQuantity()
        {
            return quantity;
        }



    }
}
