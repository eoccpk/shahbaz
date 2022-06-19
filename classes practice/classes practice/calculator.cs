using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_practice
{
    internal class calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public void input()
        {
            Console.WriteLine("enter the first number");
            this.num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            this.num2=int.Parse(Console.ReadLine());
        }
        public double add()
        {
            return num1 + num2;
        }
        public double subs()
        {
            return this.num1 - this.num2;
        }
    }
}
