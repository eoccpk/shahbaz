using System;
using System.Collections;

namespace nameslist
{
    internal class names
    {
        public void run()
        {
            ArrayList name = new ArrayList();
            name.Add("shahbaz");
            Console.WriteLine("enter the names");
            for (int i = 0; i < 3; i++)
            {
                name.Add(Console.ReadLine());
            }
            if(name.Contains("shahbaz"))
            {
                Console.WriteLine("congrats");
            }
            name.Sort();
            Console.WriteLine("print the sorted list" +
                "");
            foreach (string n in name)
            {
                Console.WriteLine("the namess are :");
                Console.WriteLine(n);
            }




        }
        


    }
}
