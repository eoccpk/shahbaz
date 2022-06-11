using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_classes
{
    internal class student
    {
        int roll_no;
        string name;
        int age;
        int standard;
        public void set_student(int roll, string name,int Age,int standard)
        {
            this.roll_no= roll;
            this.name= name;
            this.age = Age;
            this.standard = standard;
        }
        public void get_student()
        {
            Console.WriteLine("the age is: " + this.roll_no);
            Console.WriteLine("the name"+this.name);
            Console.WriteLine("the age is :"+ this.age);
            Console.WriteLine("the class is :"+this.standard);
        }
        static void Main(string[] args)
        {
            //student S1 = new student();
            //S1.set_student(20, "shahbabz", 22, 2);
            //S1.get_student();
            Console.WriteLine("enter the roll no");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the standard :");
            int sta = int.Parse(Console.ReadLine());
            student s1 = new student();
            s1.set_student(roll, name, age, sta);
            s1.get_student();
            
            Console.ReadKey();
        }
    }
}
