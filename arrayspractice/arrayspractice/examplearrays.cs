using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayspractice
{
    internal class examplearrays
    {
       public void run()
        {
            int[] marks = new int[3];
            Console.WriteLine("enter the marks in the array");
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("the marks at "+i+" " + marks[i]);
            }
        }
       

    }
}
