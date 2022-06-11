using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_2
{
    internal class student
    {
        int roll_no;
        string name;

        public void set(int Roll,string Name)
        {
            this.name = Name;
            this.roll_no = Roll;
        }
        public void get()
        {
            Console.WriteLine("the roll is:" + this.roll_no);
            Console.WriteLine("the name is:" + this.name);
        }
    }
}
