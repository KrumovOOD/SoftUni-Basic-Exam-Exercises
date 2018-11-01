using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string outfit = "Sweatshirt";
            string shoes = "Sneakers";

            if (type == "Morning")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                }
                else

                if (temperature > 18 && temperature <= 24)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
                else

                if (temperature >= 25)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                }
            }
            else

            if (type == "Afternoon")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
                else

               if (temperature > 18 && temperature <= 24)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                }
                else

               if (temperature >= 25)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Swim Suit and Barefoot.");
                }
            }
            else

            if (type == "Evening")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
                else

               if (temperature > 18 && temperature <= 24)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
                else

               if (temperature >= 25)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
            }



































            }
    }
}
