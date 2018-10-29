using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            byte dancers = byte.Parse(Console.ReadLine());
            byte days = byte.Parse(Console.ReadLine());

            var stepsByDay = Math.Ceiling(((steps / days)) / (steps) * 100);
            var percent = stepsByDay / dancers;

            if (stepsByDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percent:F2}%.");
            }
            else if (stepsByDay > 13)
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required { percent:F2}% steps to be learned per day.");
            }
        }
    }
}


