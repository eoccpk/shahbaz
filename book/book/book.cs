using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class book
    {
        string title;
        string author;
        int pages;
        int pub_year;

        public void set(string title, string aut, int page, int pub)
        {
            this.title = title;
            this.author = aut;
            this.pages = page;
            this.pub_year = pub;
        }
        public void print()
            {
            Console.WriteLine("the title of book is :"+this.title);
            Console.WriteLine("the author of book is :" + this.author);
            Console.WriteLine("the no of pages of book is :" + this.pages);
            Console.WriteLine("the title of pub year is :" + this.pub_year);
        }
        public void borrow()
        {
            string title;
            Console.WriteLine("enter the title of book to borrow");
            title=Console.ReadLine();

            if (this.title==title)
            {
                Console.WriteLine("book is available");
            }
            else
                Console.WriteLine("not available");
        }

    }
}
