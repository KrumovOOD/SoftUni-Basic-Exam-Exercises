using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());

            double shortPrice = tshirtPrice * 0.75;
            double sockPrice = shortPrice * 0.2;
            double shoesPrice = (tshirtPrice + shortPrice) * 2;

            double totalPrice = tshirtPrice + shortPrice + sockPrice + shoesPrice;

            double discount = (totalPrice * 15) / 100;
            double totalWithDiscount = totalPrice - discount;

            if (totalWithDiscount >= sum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalWithDiscount:F2} lv.");
            }
            else
                if (totalWithDiscount < sum)
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(Math.Abs(totalWithDiscount - sum)):F2} lv. more.");
            }







        }
    }
}
