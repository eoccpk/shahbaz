using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_practice
{
    internal class calculator
    {
        public int num1;
        public int num2;
        public int result;
       
        public void input()
        {
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
        }
        public void add()
        {
            result=num1+num2;
            Console.WriteLine("the result is :" + result);
            Console.ReadKey();
        }
        public void substract()
        {
            if(num2==0)
            {
                Console.WriteLine("the resuly is :" + num1);
            }
            else
                result =num1-num2;
            Console.WriteLine("the result is :"+result);
            Console.ReadKey();
        }
    }
}
