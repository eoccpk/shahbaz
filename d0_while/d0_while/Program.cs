using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d0_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double marks;
            string name;
            int roll_no;
            int no_of_students;
            Console.WriteLine("enter no of stundents");
            no_of_students = int.Parse(Console.ReadLine());
            for(int i=0;i<no_of_students;i++)
            {
                roll_no = i;
                Console.WriteLine("roll no :"+roll_no);
                Console.WriteLine("enter name");
                name=   Console.ReadLine();
                Console.WriteLine("enter marks");
                marks = double.Parse(Console.ReadLine());
                Console.WriteLine("the student "+name+" has got "+marks);
            }
            Console.ReadKey();
        }
    }
}
