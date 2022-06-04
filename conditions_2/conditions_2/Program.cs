using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("THE NUMBER IS positive ");
            }
            else
                Console.WriteLine("the number is negative");
            Console.ReadKey();
        }
        
    }
}
