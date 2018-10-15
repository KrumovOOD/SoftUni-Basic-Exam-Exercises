using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampain
{
    class Program
    {
        static void Main(string[] args)
        {
            short days = short.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            double waffles = int.Parse(Console.ReadLine());
            double pancakes = int.Parse(Console.ReadLine());

            cakes = cakes * 45;
            waffles = waffles * 5.80;
            pancakes = pancakes * 3.20;

            double totalForOneday = (cakes + waffles + pancakes) * cookers;
            double totalCampany = totalForOneday * days;
            double total = totalCampany - (totalCampany / 8);
            Console.WriteLine($"{total:F2}");

        }
    }
}
