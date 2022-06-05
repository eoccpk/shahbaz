using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_2_calculator
{
    internal class Program
    {
        private static string again;

        static void Main(string[] args)
        {
            double result = 0;
           
            do
            {
                char again;
                Console.WriteLine("enter the first number");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the second number");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("enter 1 to add");
                Console.WriteLine("enter 2 to subs");
                Console.WriteLine("enter 3 to mul");
                Console.WriteLine("enter 4 to divide");

                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        result = add(a, b);
                        Console.WriteLine("the result is " + result);
                        break;
                    case 2:
                        result = subs(a, b);
                        Console.WriteLine("the result is " + result);
                        break;
                    case 3:
                        result = mul(a, b);
                        Console.WriteLine("the result is " + result);
                        break;
                    case 4:
                        if (b > 0)
                        {
                            result = Div(a, b);
                            Console.WriteLine("the result is " + result);
                        }
                        else
                            Console.WriteLine("cannot divide");
                        break;

                }
                Console.ReadKey();
                Console.WriteLine("do you want to run again");
                again = char.Parse(Console.ReadLine());

            } while (again == "Y" || again == "y");
            

        }
        static double add(double a, double b) => a + b;
        static double subs(double a, double b) => a - b;
        static double mul(double a, double b) => a * b;
        static double Div(double a, double b) => a / b;
    }
}
