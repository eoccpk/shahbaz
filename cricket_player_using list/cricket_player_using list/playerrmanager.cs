using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricket_player_using_list
{
    internal class playerrmanager
    {
        public void run()
        {
            List<cricket_player> p1 = new List<cricket_player>();
            for(int i = 0; i <1; i++)
            {
                cricket_player p = new cricket_player();
                p.input();
                p.do_batting();
                p.do_bowlling();
                p.sixer();
                p1.Add(p);
            }
            foreach(cricket_player p in p1)
            {
                p.display();
            }
            Console.ReadKey();
        }
    }
}
