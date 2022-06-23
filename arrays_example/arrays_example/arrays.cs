using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_example
{
    internal class arrays
    {
        public int[] marks=new int[10];
        public int pr;
        public void input()
        {
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void sum()
        {
            for(int i = 0; i < marks.Length; i++)
            {
                pr = pr + marks[i];
            }
        }
        public void show()
        {
            Console.WriteLine("the result is :"+pr);
        }
    }
}
