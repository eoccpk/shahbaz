using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_01_ARRAYS
{
    internal class ARRAY_SUM
    {
        public int[] num;
        public int add = 0;
        public ARRAY_SUM()
        {
            num= new int[5];
        }
        public void input()
        {
            Console.WriteLine("enter the no in the array");
            for(int i = 0; i < num.Length; i++)
            {
                num[i]=int.Parse(Console.ReadLine());
            }
        }
        public void sum()
        {
            for(int i=0; i < num.Length; i++)
            {
                Console.WriteLine("the numbers are " + num[i]);
                add=add+num[i];
            }

        }
        public void display()
        {
            Console.WriteLine("the total sum of the array is "+add);
        }
    }
}
