using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> std = new List<student>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the details");
                student student = new student();
                student.input();
                std.Add(student);
            }
            Console.WriteLine("print the data of all the students ");
            foreach(student s in std)
            {
                s.show();
            }
            Console.ReadKey();
        }
    }
}
