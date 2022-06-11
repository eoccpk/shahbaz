using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricketplayer
{
    internal class cricket
    {
        public string full_name { get; set; }
        public string born { get; set; }
        public string age { get; set; }
        public string  batting_style {get; set;}
        public string bowling_style { get; set; }
        public string relations { get; set; }
        public void display()
        {
            Console.WriteLine("the name of the cricketer is :" + this.full_name);
            Console.WriteLine("the born of the cricketer is :" + this.born);
            Console.WriteLine("the batting style of the cricketer is :" + this.batting_style);
            Console.WriteLine("the bowling style of the cricketer is :" + this.bowling_style);
            Console.WriteLine("the relations of the cricketer is  :" + this.relations);
            
        }
        
        public void do_batting()
        {
            string player;
            Console.WriteLine("enter player name to do batting :");
            player = Console.ReadLine();
            if(player==this.full_name)
            {
                Console.WriteLine(player +" do batting its tyour turn");
            }
            else
                Console.WriteLine("no player found");
        }
        public void do_bowling()
        {
            string player;
            Console.WriteLine("enter player name to do batting :");
            player = Console.ReadLine();
            if (player == this.full_name)
            {
                Console.WriteLine(player + " do bowling ");
            }
            else
                Console.WriteLine("no player found");
        }
        public void run_sixer()
        {
            Console.WriteLine("its a sixer");
        }
        public void run_bounder()
        {
            Console.WriteLine("its a boundry ");
        }
    }

}
