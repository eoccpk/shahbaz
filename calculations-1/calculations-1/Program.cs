using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculations_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("INPUT THE RADIUS");
            double radius = int.Parse(Console.ReadLine());
            double area;
            area=pi*(radius*radius);
            Console.WriteLine("the area is: " + area);
            Console.ReadKey();
        }
    }
}
