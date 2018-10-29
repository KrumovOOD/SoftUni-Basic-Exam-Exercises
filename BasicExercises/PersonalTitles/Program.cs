using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string form = Console.ReadLine();

            if (form == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");

            }
            else if (form == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }

            else

               if (form == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");

            }
            else if (form == "f" && age < 16)
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
