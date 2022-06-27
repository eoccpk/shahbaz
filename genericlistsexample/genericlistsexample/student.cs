using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericlistsexample
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] marks { get; set; }
        public student()
        {
            Id=0;
            Name = "default name";
            marks = new int[3];
        }
        public student(int id, string name, int[] marks)
        {
            Id = id;
            Name = name;
            this.marks = marks;
        }
        public void input()
        {
            Console.WriteLine("enter the name");
             Name=Console.ReadLine();
            Console.WriteLine("enetr the ID");
            Id=int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE MARKS");
            for(int i=0;i<marks.Length;i++)
                marks[i]=int.Parse(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("the id is :"+Id);
            Console.WriteLine("the name is : "+Name);
            Console.WriteLine("THE MARKS ARE "+String.Join(" ",marks));
        }
    }
}
