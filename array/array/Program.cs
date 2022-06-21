using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int sum=0;

            //Console.WriteLine("data at location" + marks[0]);
            //marks[0] = 58;
            //Console.WriteLine("data at location" + marks[1]);
            Console.WriteLine("enter the 5 marks");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < marks.Length; i++)
            {


                sum = sum + marks[i];

            }
            Console.WriteLine("the largest number is " + sum);
            Console.ReadKey();
        }
    }
}
