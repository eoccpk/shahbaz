using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshop
{
    internal class bankaccount
    {
        public string depacc { get; set; }
        public string accounttitle { get; set; }
        public string accountmum { get; set; }
        public double balance  { get; set; }
        public string branchcode { get; set; }
        public string branchname { get; set; }
        public bankaccount()
        {
            this.accounttitle = "shahbaz hussain";
            this.balance = 0;
            this.branchcode = "0501";
            this.accountmum = "1234";
            this.branchname = "rwp";
        }
        public void input()
        {
            Console.WriteLine("ENTER THE ACCOUNT TITLE");
            accounttitle=Console.ReadLine();
            Console.WriteLine("ENTER THE ACCOUNT NUMBER");
            accountmum=Console.ReadLine();
            Console.WriteLine("ENTE THE BALANCE");
            balance=double.Parse(Console.ReadLine());
            Console.WriteLine("enter the branch code");
            branchcode=Console.ReadLine();
            Console.WriteLine("ENTE THE BRANCH NAME");
            branchname=Console.ReadLine();
        }
        public void deposit()
        {
            int dep;
            
            Console.WriteLine("enter the account number to deposit the amount");
            depacc=Console.ReadLine();
            if(depacc==this.accounttitle)
            { 
                Console.WriteLine("ENTER THE AMOUNT TO DEPOSIT");
                dep=int.Parse(Console.ReadLine());
                balance= balance+dep;
                Console.WriteLine("the new balance is "+balance);
            }

        }
    }
}
