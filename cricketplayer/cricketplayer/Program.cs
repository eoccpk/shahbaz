using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricketplayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cricket c1 = new cricket();
            Console.WriteLine("enter the name of the cricketer :");
            c1.full_name = Console.ReadLine();
            Console.WriteLine("enter the BORN DETAILS of the cricketer :");
            c1.born = Console.ReadLine();
            Console.WriteLine("enter the age of the cricketer :");
            c1.age = Console.ReadLine();
            Console.WriteLine("enter the batting style of the cricketer :");
            c1.batting_style = Console.ReadLine();
            Console.WriteLine("enter the bowling style of the cricketer :");
            c1.bowling_style = Console.ReadLine();
            Console.WriteLine("enter the relations of the cricketer :");
            c1.relations = ("adnan akmal(cousion) kamran akmal(cousion) umer akmal(cousion)");
            
            c1.display();
            c1.do_batting();
            c1.do_bowling();
            c1.run_sixer();
            c1.run_bounder();
            Console.ReadKey();

        }
    }
}
