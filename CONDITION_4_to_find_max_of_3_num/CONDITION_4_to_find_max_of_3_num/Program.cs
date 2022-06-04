using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONDITION_4_to_find_max_of_3_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num3");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
                Console.WriteLine("num3 is the greater");
            Console.ReadKey();
        }
    }
}
