using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());
            double price = 0;
            double total=0;
            double evenDiscount = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;


            }


            if (countFishers <= 6)
            {
                 total = price - (price * 10) / 100;
            }
            else

            if (countFishers >= 7 && countFishers <= 11)
            {
                 total = price - (price * 15) / 100;
            }
            else

            if (countFishers>12)
            {
                 total = price - (price * 25) / 100;
            }

            

            if (budget > total )
            {
                if (countFishers % 2 == 0 && season != "Autumn")
                {
                    evenDiscount = price - (price * 5) / 100;
                    Console.WriteLine($"Yes! You have {budget - total-evenDiscount:F2} leva left.");
                }else
                    Console.WriteLine($"Yes! You have {budget - total :F2} leva left.");


            }
            else

                Console.WriteLine($"Not enough money! You need {(Math.Abs(budget-total)):F2} leva.");
        }

    }/*Not correct exercise*/
}