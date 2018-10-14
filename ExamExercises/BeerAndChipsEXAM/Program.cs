using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerAndChipsEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            float budget = float.Parse(Console.ReadLine());
            short beer = short.Parse(Console.ReadLine());
            short chips = short.Parse(Console.ReadLine());

            var beerPrice = 1.20 * beer;
            var oneChipsPrice = beerPrice * 45 / 100;
            var totalPriceChips = Math.Ceiling(oneChipsPrice * chips);
            var totalPrice = beerPrice + totalPriceChips;
            var leftMoney = budget - totalPrice;

            if (leftMoney > 0)
            {
                Console.WriteLine($"{name} bought a snack and has {leftMoney.ToString("0.00")} leva left.");
            }
            else
                if (leftMoney < 0)
            {
                Console.WriteLine($"{name} needs {Math.Abs(leftMoney).ToString("0.00")} more leva!");
            }



        }
    }
}
