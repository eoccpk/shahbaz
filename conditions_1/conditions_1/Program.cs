using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input 1st number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("numbers are equall");
            }
            else if(num1 > num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else if(num2>num1)
            {
                Console.WriteLine("num2 is greate than num1");
            }
            else
            {
                Console.WriteLine("no input");
            }

            Console.ReadKey();
        }
    }
}
