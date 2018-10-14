using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double xCoordinates = Math.Max(x1, x2) - Math.Min(x1, x2);
            double yCoordinates = Math.Max(y1, y2) - Math.Min(y1, y2);

            Console.WriteLine(xCoordinates * yCoordinates);
            Console.WriteLine(2 * (xCoordinates + yCoordinates));


        }
    }
}
