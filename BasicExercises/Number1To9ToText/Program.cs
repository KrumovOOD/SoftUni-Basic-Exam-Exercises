using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1To9ToText
{
    class Program
    {
        static void Main(string[] args)
        {

            var number1 = int.Parse(Console.ReadLine());

            if (number1 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            if (number1 == 1) { Console.WriteLine("one"); }
            else
            if (number1 == 2) { Console.WriteLine("two"); }
            else
            if (number1 == 3) { Console.WriteLine("three"); }
            else
            if (number1 == 4) { Console.WriteLine("four"); }
            else
            if (number1 == 5) { Console.WriteLine("five"); }
            else
            if (number1 == 6) { Console.WriteLine("six"); }
            else
            if (number1 == 7) { Console.WriteLine("seven"); }
            else
            if (number1 == 8) { Console.WriteLine("eight"); }
            else
            if (number1 == 9) { Console.WriteLine("nine"); }
            else
            if (number1 >= 10)
            {
                Console.WriteLine("number too big");
            }

        }
    }
}
