﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h1 = double.Parse(Console.ReadLine());
            var result = (b1 + b2) * h1 / 2;
            Console.WriteLine(result);

        }
    }
}
