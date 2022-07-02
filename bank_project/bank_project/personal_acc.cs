using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    internal class personal_acc :accounbt
    {
        public double balance { get; set; }
        public  personal_acc():base()
        {
            balance = 2000;
        }
       
        public  void deposit()
        {
            base.input();
            base.active();
            base.ammountdeposit();
            balance = balance + amountdep;
            Console.WriteLine("THE NEW BALANCE IS :"+balance);
        }
        public void  withdraw()
        {
            base.withdrawammount();
            balance = balance - minus;
            Console.WriteLine("your new balance after withdraw is  "+balance );
        }
    }
}
