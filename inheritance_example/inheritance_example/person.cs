using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example
{
    internal class person
    {
        public string Name { get; set; }
        public string age { get; set; }
        public string cnic { get; set; }
        public person()
        {
            Name = "default";
            age = "0";
            cnic = "0";
        }
        public virtual void input()
        {
            Console.WriteLine("enter the name");
            Name = Console.ReadLine();
            Console.WriteLine("enter the age ");
            age = Console.ReadLine();
            Console.WriteLine("enter the cnic");
            cnic = Console.ReadLine();
        }
        public virtual void show()
        {
            Console.WriteLine("the name is " + Name);
            Console.WriteLine("the age is " + age);
            Console.WriteLine("the cnic is " + cnic);
        }

    }
}