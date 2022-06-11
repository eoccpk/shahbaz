using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            obj.name = Console.ReadLine();
            obj.Roll_no = 100;
            obj.marks = 20;
            obj.show();
            Console.WriteLine("_________________________________");
            student obj2 = new student();
            obj2.name = "shahbaz";
            obj2.marks = 10;
            obj2.Roll_no = 1;
            obj2.show();
            Console.ReadKey();
        }
    }
}
