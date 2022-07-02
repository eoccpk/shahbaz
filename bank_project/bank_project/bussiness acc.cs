using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    internal class bussiness_acc:accounbt
    { 
        public double balance { get; set; }
        public bussiness_acc():base()
        {
            balance = 10000;
        }
        public void deposit()
        {
            base.input();
            base.active();
            base.ammountdeposit();
            balance = balance + amountdep;
            Console.WriteLine("the balance after deposit amount is "+balance);
        }
        public void withdraw()
        {
            base.withdrawammount();
            balance = balance - minus;
            Console.WriteLine("the balance after withdraw is :"+balance);
        }
    }
}
