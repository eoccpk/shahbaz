using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teacher t1 =new teacher();
            //t1.input();
            //t1.show();
            //studentcs s1 =new studentcs();
            //s1.input();
            //s1.show();
            person s1 = new teacher();
            s1.input();
            s1.show();
            Console.ReadKey();
        }
    }
}
