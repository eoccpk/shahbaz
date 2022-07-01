using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example
{
    internal class teacher:person
    {
        public int subjectcode { get; set; }
        public string subject { get; set; }
        public teacher():base()
        {
            subject = "abc";
            subjectcode = 0;
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("enter the teacher subject in string");
            subject=Console.ReadLine();
            Console.WriteLine("enter the teacher subjectcode");
            subjectcode=int.Parse(Console.ReadLine());
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("the teacher subject is "+subject);
            Console.WriteLine("the subjectcode is "+subjectcode);
        }
    }
}
