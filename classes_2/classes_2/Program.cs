using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            Console.WriteLine("enter roll no : ");
            int roll =int.Parse(Console.ReadLine());
            Console.WriteLine("enter name :");
            string nam = Console.ReadLine();
            s1.set(roll, nam);
            s1.get();
            Console.ReadKey();

        }
    }
}
