using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_functions
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number 1");
            double num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter the number 2");
            //double num2 = double.Parse(Console.ReadLine());
            if(prime(num1))
            {
                Console.WriteLine(num1 + " is  a prime");
            }
            else
                Console.WriteLine(num1+" is a not prime number");
            Console.ReadKey();
        }
        public static bool prime(double a)
        {
            for(int i=2;i<a;i++)

                if(a%i==0)
                
                    return false;
                
                return true;
            
        }
       
    }
}
