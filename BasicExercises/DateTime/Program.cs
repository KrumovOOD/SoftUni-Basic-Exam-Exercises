using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            DateTime hm = DateTime.ParseExact($"{hour}:{minutes}", "H:m", null);

            hm = hm.AddMinutes(15);

            Console.WriteLine(hm.ToString("H:mm"));


        }
    }
}
