using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kindly input the temperature in the celcius");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double farenheit;
            farenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("the temperature in farenheit is " + farenheit);
            string str= farenheit.ToString();
            Console.WriteLine("the temperature is " + (str+"f" +" & "+ celcius+"C"));
            Console.ReadKey();
        }
    }
}
