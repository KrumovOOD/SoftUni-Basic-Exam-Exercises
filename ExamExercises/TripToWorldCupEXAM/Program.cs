using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripToWorldCupEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            float goTicket = float.Parse(Console.ReadLine());
            float backTicket = float.Parse(Console.ReadLine());
            float ticketPrice = float.Parse(Console.ReadLine());
            sbyte countMatch = sbyte.Parse(Console.ReadLine());
            sbyte discount = sbyte.Parse(Console.ReadLine());

            var totalTicketPrice = (goTicket + backTicket) * 6;
            var totalTicketPriceWithDiscount = totalTicketPrice - (totalTicketPrice * discount / 100);
            var matchTicketPrice = 6 * countMatch * ticketPrice;
            var totalPriceToPay = totalTicketPriceWithDiscount + matchTicketPrice;
            var sum = totalPriceToPay / 6;

            Console.WriteLine($"Total sum: { totalPriceToPay.ToString("0.00") } lv.");
            Console.WriteLine($"Each friend has to pay { sum.ToString("0.00") } lv.");

        }
    }
}
