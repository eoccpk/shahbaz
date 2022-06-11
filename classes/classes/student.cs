using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class student
    {
        public int Roll_no { get; set; }
        public string name { get; set; }
        public int marks { get; set; }
        public void show()
        {
            Console.WriteLine("roll no is :"+Roll_no);
            Console.WriteLine("name :" + name);
            Console.WriteLine("marks :" + marks);
        }
    }
}
