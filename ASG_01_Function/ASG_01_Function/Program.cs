using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_01_Function
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("enter ist number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Max(num1, num2);
            Console.ReadKey();

        }
        static int Max(int a,int b) 
        {
            int result;
            if (a > b)
            {
                result = a;
                Console.WriteLine("the greater number is :" + result);
                return 0;
            }
            else
            {
                result = b;
                Console.WriteLine("the greater is: " + result);
                
                return 0;
            }
        }
    }
}
