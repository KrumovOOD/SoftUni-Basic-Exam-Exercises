using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inch_To_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            double result = inches * 2.54;
            Console.WriteLine("Cm= " + result);



        }
    }
}
