using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_asg_02
{
    internal class bank
    {
        public string account_title { get; set; }
        public int account_number { get; set; }
        
        public string type{ get; set; }
        
        public int balance { get; set; }
        public int branch_code { get; set; }
        public  string branch_name { get; set; }
        public bank()
        {
            account_title = "0";
            account_number = 0;
            type = "0";
            balance = 0;
            branch_code = 0;
            branch_name= "0";
        }
        public void display()
        {
            Console.WriteLine("the acount title is :" +account_title);
            Console.WriteLine("the acount number is :" + account_number);
            Console.WriteLine("the acount type is :" + type);
            Console.WriteLine("the acount balance is :" + balance);
            Console.WriteLine("the acount branch code is :" + branch_code);
            Console.WriteLine("the acount branch name is :" + branch_name);
        }
        public void deposit()
        {
            string title; 
            int amount;
            Console.WriteLine("enter the account_title to deposit:");
            title = Console.ReadLine();
            if (title == this.account_title)
            {
                Console.WriteLine("enter the amount to deposit :");
                amount = int.Parse(Console.ReadLine());
                this.balance = balance + amount;
                Console.WriteLine("the deposited amount in :" + this.account_title + " is :" + this.balance);
            }
            else
                Console.WriteLine("no account exist");
        }
         public void withdraw()
            {
            string title;
            int deduct;
            Console.WriteLine("enter the title of account to deduct");
            title = Console.ReadLine();
            if(title==this.account_title)
            {
                Console.WriteLine("enter the amount to deduct");
                deduct = int.Parse(Console.ReadLine());
                this.balance=balance - deduct;
                Console.WriteLine("the amount after deduction is: "+this.balance);

            }
            else
                Console.WriteLine("no account exists");
            }
        }
    }

