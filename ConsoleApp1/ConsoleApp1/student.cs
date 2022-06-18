using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class student
    {
        public string color { get; set; }
        public string make { get; set; }
        public int model { get; set; }
        public static string country { get; set; }
      public student()
        {
            color = "0";
            make = "0";
            model = 0;
        }
        public void input()
        {
            Console.WriteLine("enter color"); ;
            this.color = Console.ReadLine();
            Console.WriteLine("enter MAKE");
            this.make= Console.ReadLine();
            Console.WriteLine("enter model");
            this.model = int.Parse(Console.ReadLine());
          
        }
        public student(string color,string Make,int Model)
        {
            this.color = color;
            this.make = Make;
               this.model = Model;
            
        }
        public void show()
        {
            Console.WriteLine("the color is "+ this.color);
            Console.WriteLine("the make no is "+this.make);
            Console.WriteLine("the model are "+this.model);
            Console.WriteLine("the country is "+country);
        }
        public void start()
        {
            string ch;
            Console.WriteLine("enter start to start the car");
            ch = Console.ReadLine();
            if(ch== "start")
            {
                Console.WriteLine("car is now started ");
            }
            else
                Console.WriteLine("connot start key is invalid");
        }
        public void stop()
        {
            string ch;
            Console.WriteLine("enter stop to stop the car ");
            ch=Console.ReadLine();
            if( ch== "stop")
            {
                Console.WriteLine("the car is now stopped ");
            }
            else
                Console.WriteLine("cannot stopped the car ");
        }
    }
}
