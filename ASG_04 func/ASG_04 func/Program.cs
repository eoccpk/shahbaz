using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_04_func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number :");
            double number= double.Parse(Console.ReadLine());
            Table(number);
            Console.ReadKey();
        }
        static double Table(double number)
        {
            for(int i = 1; i <= 10; i++)
            {
                double result = number * i;
                Console.WriteLine(number + "*" + i + "=" + result);
            }
            return 0;
        }
    }
}
