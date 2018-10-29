using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            var hhmm = TimeSpan.FromMinutes(hour).ToString(@"h\:mm");

            Console.WriteLine(hhmm);
        }
    }
}
