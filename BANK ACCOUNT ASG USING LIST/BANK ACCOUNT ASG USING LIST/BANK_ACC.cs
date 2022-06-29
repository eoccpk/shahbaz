using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_ACCOUNT_ASG_USING_LIST
{
    internal class BANK_ACC
    {
        public string accountitle { get; set; }
        public string accountno { get; set; }

        public BANK_ACC()
        {
            accountitle = "default";
            accountno = "0000";
        }
        public void input()
        {
            Console.WriteLine("enter account title");
            accountitle = Console.ReadLine();
            Console.WriteLine("enter the account no");
            accountno = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("the account title is "+accountitle);
            Console.WriteLine("the account no is "+accountno);
        }
    }
}
