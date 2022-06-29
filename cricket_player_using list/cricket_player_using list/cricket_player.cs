using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricket_player_using_list
{
    internal class cricket_player
    {
        public string fullname { get; set; }
        public string dob { get; set; }
        public string age { get; set; }
        public string battingstyle { get; set; }
        public string bowlingstyle { get; set; }
        public string playerrole { get; set; }
        public string[] relations { get; set; }
        public cricket_player()
        {
            fullname = "shahbaz";
            dob = "----";
            age = "0000";
            battingstyle = "none";
            bowlingstyle = "none";
            playerrole = "none";
            relations = new string[3];  
        }
        public void input()
        {
            Console.WriteLine("enter the full namee");
            fullname=Console.ReadLine();
            Console.WriteLine("enter the dob");
            dob=Console.ReadLine();
            Console.WriteLine("enter the age");
            age=Console.ReadLine();
            Console.WriteLine("ente the batting style");
            battingstyle=Console.ReadLine();
            Console.WriteLine("enter the bowling style ");
            bowlingstyle=Console.ReadLine();
            Console.WriteLine("enter the player role ");
            playerrole=Console.ReadLine();
            Console.WriteLine("ENETR THE RELATIONS OF THE PLAYER");
            for(int i=0;i<relations.Length;i++)
            {
                relations[i] = Console.ReadLine();
            }
        }
        public void do_batting()
        {
            string ch;
            Console.WriteLine("enter the player name to bat");
            ch = Console.ReadLine();
            if (ch == fullname)
            {
                Console.WriteLine("do batting");
            }
            else
                Console.WriteLine("wrong player");
        }
        public void do_bowlling()
        {
            string ch;
            Console.WriteLine("enter the name of the player to bowling");
            ch= Console.ReadLine();
            if (ch == fullname)
            {
                Console.WriteLine("do bowling");
            }
            else
                Console.WriteLine("wrong player"); 
        }
        public void sixer()
        {
            Console.WriteLine("this is a sixer and a boundry");
        }
        public void display()
        {
            Console.WriteLine("the full name is "+fullname);
            Console.WriteLine("the dob is "+dob);
            Console.WriteLine("the age is "+age);
            Console.WriteLine("the player role is "+playerrole);
            Console.WriteLine("the relations are "+string.Join("\n",relations));
        }

    }
}
