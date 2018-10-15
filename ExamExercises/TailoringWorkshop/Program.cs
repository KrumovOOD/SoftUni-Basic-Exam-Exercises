using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort table = ushort.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidht = double.Parse(Console.ReadLine());

            double area = table * (tableLenght + 2 * 0.30) * (tableWidht + 2 * 0.30);
            double areaKar = table * (tableLenght / 2) * (tableLenght / 2);
            double usdPrice = area * 7 + areaKar * 9;
            double bgnPrice = usdPrice * 1.85;

            Console.WriteLine($"{usdPrice:F2} USD");
            Console.WriteLine($"{bgnPrice:F2} BGN");




        }
    }
}
