﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());
            var result = firstTime + secondTime + thirdTime;
            TimeSpan t = TimeSpan.FromSeconds(result);
            if (result > 0 && result <= 59)
            {

                Console.WriteLine("0:" + "0" + t.Seconds);
            }
            else
            {
                if (result >= 60 && result <= 119)
                {
                    if (t.Seconds == 1 | t.Seconds == 2 | t.Seconds == 3)
                        Console.WriteLine("1:" + "0" + t.Seconds);
                }
                else
                {
                    if (result >= 120 & result <= 179)
                    {
                        Console.WriteLine("2:" + t.Seconds);
                    }
                }





            }
        }
    }
}

