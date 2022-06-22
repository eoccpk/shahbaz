using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    internal class student
    {
        public int roll_no { get; set; }
        public string name { get; set; }
        public int marks { get; set; }
        public student()
        {
            name = "default name";
            roll_no = 0;
            marks = 0;
        }
        public void input()
        {
            Console.WriteLine("enter the name of the student");
            name=Console.ReadLine();
            Console.WriteLine("enter the roll no");
            roll_no=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks ");
            marks=int.Parse(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("the name of the student is :"+name);
            Console.WriteLine("the roll no of the student is :" + roll_no);
            Console.WriteLine("the marks of the student is :" + marks);
        }
    }
}
