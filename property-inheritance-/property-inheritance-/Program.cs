using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inheritance property software ");
            Console.WriteLine("enter the number of prople");
            int total_people =int.Parse(Console.ReadLine());
            Console.WriteLine("enter the property in marlas");
            double marlas = Convert.ToDouble(Console.ReadLine());
            double per_peice = marlas / total_people;
            Console.WriteLine("the per person share for male is: "+per_peice+" marlas");
            double female_pershare = per_peice / 2;
            Console.WriteLine("the share for females is         :" +female_pershare+" marlas");
            Console.ReadKey();

        }
    }
}
