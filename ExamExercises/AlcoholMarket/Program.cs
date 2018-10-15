using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            float whiskeyPrice = float.Parse(Console.ReadLine());
            float beerInLiters = float.Parse(Console.ReadLine());
            float wineInLiters = float.Parse(Console.ReadLine());
            float hotWaterInLiters = float.Parse(Console.ReadLine());
            float whiskeyInLiters = float.Parse(Console.ReadLine());

            double hotwaterPrice = whiskeyPrice / 2;
            double winePrice = hotwaterPrice - (0.4 * 25);
            double beerPrice = hotwaterPrice - (0.8 * 25);

            double hotWaterInLiterss = hotWaterInLiters*hotwaterPrice;
            double wineInLiterss = wineInLiters * winePrice;
            double beerInLiterss = beerPrice * beerInLiters;
            double whiskeyy = whiskeyInLiters * whiskeyPrice;
            
            double totalPrice = hotWaterInLiterss + wineInLiterss + beerInLiterss + whiskeyy;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
