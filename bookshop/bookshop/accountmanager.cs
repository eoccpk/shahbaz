using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshop
{
    internal class accountmanager
    {
        public void Run()
        {
            bankaccount A1 = new bankaccount();
            A1.input();
            A1.deposit();
            Console.ReadKey();

        }
    }
}
