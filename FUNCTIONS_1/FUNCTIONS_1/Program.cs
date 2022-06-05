using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCTIONS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print(10);
            print(20);
            for(int i = 0; i < 3; i++)
            {
                print(40);
            }
            Console.ReadKey();
        }
        static void print(int num)
        {
            Console.WriteLine("i am a function");
            Console.WriteLine("call me again"+num);
        }
       
    }
}
