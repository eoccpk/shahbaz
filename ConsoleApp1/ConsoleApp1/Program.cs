using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            student.country = "Pakistan";

            s1.input();

            s1.show();
            s1.start();
            s1.stop();
            Console.ReadKey();
        }
    }
}
