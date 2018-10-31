using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.50:F2}");
                }
                else

                if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.20:F2}");
                }
                else

                if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.85:F2}");
                }
                else

                if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.45:F2}");
                }
                else

                if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 2.70:F2}");
                }
                else

                if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.50:F2}");
                }
                else

                if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 3.85:F2}");
                }
                else
                    Console.WriteLine("error");

            }

            else

            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.70:F2}");
                }
                else

                if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.25:F2}");
                }
                else

                if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.90:F2}");
                }
                else

                if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.60:F2}");
                }
                else

                if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 3.00:F2}");
                }
                else

                if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.60:F2}");
                }
                else

                if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 4.20:F2}");
                }
            }
            else Console.WriteLine("error");


        }
    }
}
