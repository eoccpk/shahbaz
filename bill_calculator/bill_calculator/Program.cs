using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bill_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int telephone = int.Parse(Console.ReadLine());
            double charji = 2424.23;
            double smarttv = 2536.22;
            double discount = 0;
            string name = "shahbaz hussain";
            string address = "rawalpindi";
            double total_bill = telephone+charji+smarttv+discount;
            Console.WriteLine("your total bill is :" + total_bill);
            double service_charges = total_bill * 9.9 / 100;
            Console.WriteLine("your service charges are: " + service_charges);
            double WTH = service_charges + total_bill * 8.5 / 100;
            Console.WriteLine("your WTH IS: " + WTH);
            double total_amount = WTH + service_charges + total_bill;
            Console.WriteLine("your total bill is " + total_amount +"  for  "+ name+" "+address);
            Console.ReadKey();
        }

    }
}
