using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = double.Parse(Console.ReadLine());
            var farenheit = celcius * (1.8) + 32;
            Console.WriteLine(Math.Round(farenheit, 2));

        }
    }
}
