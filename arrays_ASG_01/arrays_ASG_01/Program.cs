using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_ASG_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<sum_of_array> s1 = new List<sum_of_array>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("now new data input: ");
                sum_of_array s2 = new sum_of_array();
                s2.input();
                s2.sum();
                s1.Add(s2);
            }
            foreach(sum_of_array s2 in s1)
            {
                Console.WriteLine("shwoing the sums");
                s2.show();
            }
            Console.ReadKey();
        }
    }
}
