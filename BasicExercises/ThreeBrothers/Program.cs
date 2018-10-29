using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / a + 1 / b + 1 / c);
            double timeToRest =totalTime+(totalTime*15)/100;
            double timeLeft = d - timeToRest;


            Console.WriteLine($"Cleaning time: {timeToRest:F2}");

            if (timeLeft>0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }else
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Floor(Math.Abs(timeLeft))} hours.");

        }
    }
}
