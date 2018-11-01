using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double weekends = 46 * 3.0 / 4;
            double gamesInHoliday = p * h / 3.0;
            double totalGames = weekends + h + gamesInHoliday;
            double leapYearDiscount = (totalGames * 15) / 100;
            double total = Math.Floor(totalGames + leapYearDiscount);

            if (year == "leap")
            {
                Console.WriteLine(total);
            }

           
        }
    }
}
