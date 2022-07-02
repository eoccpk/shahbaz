using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ab;
            do
            {
                Console.WriteLine("enter 1 for business account");
                Console.WriteLine("enter 2 for personal account");
                int ch;
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        bussiness_acc b1 = new bussiness_acc();
                        b1.deposit();
                        b1.withdraw();
                        break;
                    case 2:
                        personal_acc p1 = new personal_acc();
                        p1.deposit();
                        p1.withdraw();
                        break;
                }
                Console.WriteLine("press y to run again or press n to abort");
                ab = Console.ReadLine();

            } while (ab == "y" || ab == "Y");
           


            Console.ReadKey();





        }
    }
}
