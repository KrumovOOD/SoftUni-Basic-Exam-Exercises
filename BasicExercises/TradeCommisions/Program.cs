using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double discount;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{discount = (sales * 5) / 100:F2}");
                }
                else

                if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{discount = (sales * 7) / 100:F2}");
                }
                else

                if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{discount = (sales * 8) / 100:F2}");
                }
                else

                if (sales > 10000)
                {
                    Console.WriteLine($"{discount = (sales * 12) / 100:F2}");
                }
                else
                    Console.WriteLine("error");

            }
            else

            if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{discount = (sales * 4.5) / 100:F2}");
                }
                else

                if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{discount = (sales * 7.5) / 100:F2}");
                }
                else

                if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{discount = (sales * 10) / 100:F2}");
                }
                else

                if (sales > 10000)
                {
                    Console.WriteLine($"{discount = (sales * 13) / 100:F2}");
                }
                else
                    Console.WriteLine("error");


            }
            else

            if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{discount = (sales * 5.5) / 100:F2}");
                }
                else

                if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{discount = (sales * 8) / 100:F2}");
                }
                else

                if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{discount = (sales * 12) / 100:F2}");
                }
                else

                if (sales > 10000)
                {
                    Console.WriteLine($"{discount = (sales * 14.5) / 100:F2}");
                }
                else
                    Console.WriteLine("error");


            }
            else Console.WriteLine("error");
        }

    }
}
