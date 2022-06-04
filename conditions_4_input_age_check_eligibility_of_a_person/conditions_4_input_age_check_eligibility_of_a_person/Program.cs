using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions_4_input_age_check_eligibility_of_a_person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name of the person for casting the vote");
            string name =Console.ReadLine();
            Console.WriteLine("eligibility criteria is above 18 for casting the vote");
            Console.WriteLine("enter the AGE of the person ");
            int age=int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine(name + " can cast vote ");
            }
            else
            Console.WriteLine("not eligible for vote casting");
            Console.ReadKey();
        }
    }
}
