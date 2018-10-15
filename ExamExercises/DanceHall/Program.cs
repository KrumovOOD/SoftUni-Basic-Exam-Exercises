using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            /*...............*/
            double length = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double sideMeters = double.Parse(Console.ReadLine());

            double sizeHall = (length * 100) * (widht * 100);
            double sizeFurniture = (sideMeters * 100) * (sideMeters * 100);
            double sizePeika = sizeHall / 10;
            double freeSpace = sizeHall - sizeFurniture - sizePeika;
            double numDancers = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(numDancers));
        }
    }
}
