using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop_currency_dispense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_amount = 0;
            while(total_amount < 1000)
            {
               double max= total_amount * 0.0001;
                Console.WriteLine("total " + max);
                total_amount++;
            }
            Console.ReadKey();
        }
    }
}
