using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score:");
            var number = int.Parse(Console.ReadLine());

            if (number <= 100)
            {
                Console.WriteLine("Bonus score: 5");
                Console.WriteLine("Total score:" + number + 5);
            }

        }
    }
}

