using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            accountmanager manager = new accountmanager();
            manager.Run();
        }
    }
}
