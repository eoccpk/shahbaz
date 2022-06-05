using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_05_print_table_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetr the number for the table: ");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine("____________________________________");
            int mul;
            int i = 1;
            for(i = 1; i <= 10; i++)
            {
                mul = number * i;
                Console.WriteLine(number + "*" + i +"="+ mul);
            }
            Console.ReadKey();
        }
    }
}
