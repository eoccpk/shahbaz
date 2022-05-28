using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to EOCC");
            /*string account_number = Console.ReadLine();
            Console.WriteLine("your account no is: " + account_number);
            int PINCODE = int.Parse(Console.ReadLine());
            Console.WriteLine("YOUR PIN CODE IS :" + PINCODE);*/
            /*int marks;
            marks = 100;
            marks = 20;
            Console.WriteLine("your marks are: " + marks);
            double d;
            d = 12626621.2626262;
            int i =(int)d;
            Console.WriteLine("the number is :" +i);*/
            /*int i = 757743;
            double d = 162262663.222;
            bool b = true;
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(b);*/
            int val = 272;
            int a = 200;

            string msg = "There are " + val.ToString() + " hawks";
            string msg1 = "There are " + Convert.ToString(val) + " hawks";
            string msg2 = string.Format("There are {0} and {1} hawks", val,a);
            string msg3 = $"There are {val} hawks";

            Console.WriteLine(msg);
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            Console.WriteLine(msg3);
            Console.ReadKey();
            
  }
    }
}
