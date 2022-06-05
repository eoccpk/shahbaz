using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_04_SQUARES_OF_THE_NUMBERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double square;
            for(i= 0; i < 5; i++)
            {
                square=i*i;
                Console.WriteLine("THE NUMBER "+i+" and its square is "+square);
            }
            Console.ReadKey();
        }
    }
}
