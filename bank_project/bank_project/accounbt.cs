using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    internal class accounbt
    {
        public string account { get; set; }
        public string accountname { get; set; }
        public string branchcode { get; set; }
        public double amountdep { get; set; }
        public double minus { get; set; }
        public accounbt()
        {
            account = "00000";
            accountname = "0000";
            branchcode = "0000";
            amountdep = 0;
            minus = 0;
        }
        public  void input()
        {
            Console.WriteLine("enter the account name :");
            accountname=Console.ReadLine();
            Console.WriteLine("enter the account no :");
            account = Console.ReadLine();
            Console.WriteLine("entger the branch code :");
            branchcode=Console.ReadLine();
        }
        public void active()
        {
            
        

                string avt;
                Console.WriteLine("enter the active to avtivate the account :");
                avt = Console.ReadLine();
            try
            {
                if (avt == "active")
                {
                    Console.WriteLine("the account has been now activated :");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception caught");
            }
            finally 
            { Console.WriteLine("done"); 
            }
        }
        
        public  void ammountdeposit()
        {
            Console.WriteLine("enter the amount to deposit in the bank");
            amountdep = double.Parse(Console.ReadLine());
        }
        public  void withdrawammount()
        {
            Console.WriteLine("enter the amount to withdraw in the bank");
            minus = double.Parse(Console.ReadLine());
        }
        public  void show()
        {
            Console.WriteLine("the account name is :"+accountname);
            Console.WriteLine("the account no is :"+account);
            Console.WriteLine("the branch code is :"+branchcode);
        }

    }
}
