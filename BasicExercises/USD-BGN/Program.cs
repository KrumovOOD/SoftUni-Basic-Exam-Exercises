using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            double conversion = value * 1.79549;
            Console.WriteLine($"{conversion :F2} BGN ");
        }
    }
}
