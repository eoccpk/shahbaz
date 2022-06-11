using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_asg_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b1 = new bank();
            b1.account_title = "shahbaz";
            b1.account_number = 1234;
            b1.type = "current";
            b1.balance = 2000;
            b1.branch_code = 111;
            b1.branch_name = "allied bank";
            b1.display();
            b1.deposit();
            b1.withdraw();
            Console.ReadKey();

        }
    }
}
