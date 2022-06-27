using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericlistsexample
{
    internal class lsitmanager
    {
        public void Run()
        {
            List<student> newstudent = new List<student>();
            for(int i = 0; i < 3; i++)
            {
                student s1 = new student();
                s1.input();
                newstudent.Add(s1);
            }
            Console.WriteLine("SHOW THE STUDENTS LIST");
            foreach(student s in newstudent)
            {
                s.show();
            }
            Console.ReadKey();

        }
    }
}
