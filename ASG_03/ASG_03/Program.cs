﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            int sum =0;
            while(i < 5)
            {
                sum = sum + i;
                Console.WriteLine("the number is"+i +"and sum is "+sum);
                i++;
            }
            Console.ReadKey();
        }
    }
}
