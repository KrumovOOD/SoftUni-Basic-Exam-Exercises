using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumIncomeEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectorSize = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            var incomeSector = (stadiumCapacity * ticketPrice) / sectorSize;


            var totalIncome = incomeSector * sectorSize;


            var charityMoney = (totalIncome - (incomeSector * 0.75)) / 8;


            Console.WriteLine($"Total income - {totalIncome.ToString("0.00")} BGN");
            Console.WriteLine($"Money for charity - {charityMoney.ToString("0.00")} BGN");

        }
    }
}
