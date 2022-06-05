using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_01_FOR_LOOP_AND_WHILE_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("enter no of times you want to ptint");
            int num= int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("i love pakisan");
                i++;
            }
            while (i < num);
            Console.ReadKey();
        }
    }
}
