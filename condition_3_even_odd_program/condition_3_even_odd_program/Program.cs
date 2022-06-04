using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_3_even_odd_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number= int.Parse(Console.ReadLine());
            if (number%2 !=0)
            {
                Console.WriteLine("the number is odd");
            }
            else
                Console.WriteLine("the number is even");
            Console.ReadKey();
        }
    }
}
