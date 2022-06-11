using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book b1=new book();
            b1.set("physics", "ali", 100, 1990);
            b1.print();
            b1.borrow();
            book b2 = new book();
            b2.set("chamistry", "marvis", 100, 1992);
            b2.print();
            b2.borrow();
            Console.ReadKey();

        }
    }
}
