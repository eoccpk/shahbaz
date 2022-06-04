using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_biggest_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num=0;
            double middle=0;
            double small=0;
            Console.WriteLine("input the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input the third number");
            double num3 = Convert.ToDouble(Console.ReadLine());
            if(num1 > num2 && num1>num3 )
            {
                num = num1;
            }
            if (num1 < num2 && num1>num3)
            {
                num = num2;
            }
            if (num1 < num2 && num1<num3)
            {
                num = num3;
            }
            //checking values of num2
          if(num2>num1 && num2>num3)
            {
                middle = num1;
            }
          if(num2<num1 && num2 >num3)
            {
                middle = num2;
            }
          if(num2<num1 && num2<num3)
            {
                middle=num3;
            }
            //checking values of num3
            if (num3 > num1 && num3 > num2)
            {
                small = num1;
            }
            if (num3 < num1 && num3 > num2)
            {
                small = num2;
            }
            if (num3 < num1 && num3 < num2)
            {
                small = num3;
            }
           
            Console.WriteLine(num1);
            Console.WriteLine(middle);

            Console.WriteLine(small);
            Console.ReadKey();
        }
    }
}
