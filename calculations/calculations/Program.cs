using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          SHAHBAZ EOCC");
            Console.Write("input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum= num1+ num2;
            Console.WriteLine("THE SUM IS :" + sum);
            int sub = num1 - num2;
            Console.WriteLine("THE SUBSTRACTION IS :"+sub);
            int mul = num1 * num2;
            Console.WriteLine("THE product is : "+ mul);
            double div;
            if(num1==0)
            {
                Console.WriteLine("result is infinity");
            }
            else
            {
               div = num1 / num2;
               Console.WriteLine("THE RESULT IS :" + div);
            }
            
            Console.ReadKey();

        }
    }
}
