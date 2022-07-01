using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example
{
    internal class studentcs :person
    {

        public string rollno { get; set; }
        public int marks { get; set; }
        public studentcs():base()
        {
            rollno = "abc";
            marks = 0;
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("enter the student roll no in string");
            rollno = Console.ReadLine();
            Console.WriteLine("enter the student marks");
            marks = int.Parse(Console.ReadLine());
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("the rollno is " + rollno);
            Console.WriteLine("the marks is " + marks);
        }
    }
}
