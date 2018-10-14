using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            if (date.DayOfWeek == DayOfWeek.Friday && date.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Party night! Today is : " + DayOfWeek.Friday);
            }

        }
    }
}
