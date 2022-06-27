using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraypreactice
{
    internal class arraylist
    {
        public void Run()
        {
            ArrayList marks = new ArrayList();
            Console.WriteLine("enter the marks");
            marks.Add(58);
            marks.Add(33);
            marks.Add(443);
            Console.WriteLine("enter the ,marks more");
            for (int i = 0; i < 4; i++)
            {
                marks.Add(int.Parse(Console.ReadLine()));
            }
            marks.Sort();
            Console.WriteLine("print sorted");
            for(int i = 0; i < marks.Count; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
