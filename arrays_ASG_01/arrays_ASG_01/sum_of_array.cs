using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_ASG_01
{
    internal class sum_of_array
    {
        double product = 0;
        int[] numbers = new int[5];
        public void input()
        {
            Console.WriteLine("please enter the 5 numbers :");
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        public void sum()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                product=product+numbers[i];
            }
        }
        public void show()
        {
            Console.WriteLine("the sum of the numbers are :"+product);

        }

    }
}
