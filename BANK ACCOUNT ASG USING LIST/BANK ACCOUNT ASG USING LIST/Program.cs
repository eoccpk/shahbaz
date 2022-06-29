using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_ACCOUNT_ASG_USING_LIST
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<BANK_ACC> A1 = new List<BANK_ACC>();
            for (int i = 0; i < 2; i++)
            {
                BANK_ACC stu = new BANK_ACC();
                stu.input();
                A1.Add(stu);
            }
            foreach(BANK_ACC ad in A1)
            {
                ad.display();  
            }
            Console.ReadKey();
        }
    }
}
