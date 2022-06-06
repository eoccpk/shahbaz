using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_03_FUNCTIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length :");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the width :");
            double width = double.Parse(Console.ReadLine());
            double total_area = Area(length, width);
            Console.WriteLine("the total area is :" + total_area);
            Console.ReadKey();
        }
        static double Area(double length, double width) => length * width;
 
       
    }
}
