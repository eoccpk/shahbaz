using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_practice
{
    internal class student
    {
        public void call() { 
        calculator c1 = new calculator();
        c1.input();
            Console.WriteLine("the result is :" + c1.add());
            Console.WriteLine("the reult of subs is "+c1.subs());
            Console.ReadKey();
        }
    }
}
