using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG_02_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            char ch;
            double result;
            do 
            { 
            Console.WriteLine("enter the ist number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2nd number:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter 1 for addition");
            Console.WriteLine("enter 2 for substraction");
            Console.WriteLine("enter 3 for multiplication");
            Console.WriteLine("enter 4 for division");
            Console.WriteLine("enter the choice");
            n=int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        result = add(num1, num2);
                        Console.WriteLine("the result is :" + result);
                        break;
                    case 2:
                        result = subtract(num1, num2);
                        Console.WriteLine("the result for substraction is :" + result);
                        break;
                    case 3:
                        result = multiply(num1, num2);
                        Console.WriteLine("the result for multiplication is :" + result);
                        break;
                    case 4:
                        if (num2 > 0)
                        {
                            result = divide(num1, num2);
                            Console.WriteLine("the result for multiplication is :" + result);
                        }
                        else
                            Console.WriteLine("cannot divide");
                        break;
                }


                Console.WriteLine("do you want to continue press Y or y");
                ch = char.Parse(Console.ReadLine());
                
            }
            while (ch == 'y' || ch == 'Y');
            Console.ReadKey();


        }
        static double add(double a, double b) => a + b;
        static double subtract(double a, double b) => a - b;
        static double multiply(double a, double b) => a * b;
        static double divide(double a, double b) => a / b;
    }
}
