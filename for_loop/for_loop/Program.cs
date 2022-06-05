using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int sum = 0;
            for(j = 0; j < 10; j++)
            {
                sum = sum + j;
                Console.WriteLine("\t"+sum+"\n");
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
