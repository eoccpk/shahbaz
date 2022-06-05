using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_02_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for(i = 1; i <= 10; i++)
            {
                Console.WriteLine("the counting from 1 to 10 is :" + i);
            }
            Console.ReadKey();
        }
    }
}
