using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueToConvert = double.Parse(Console.ReadLine());
            /*string currentCurrency = Console.ReadLine();
            string desiredCurrency = Console.ReadLine();*/

            double usd = valueToConvert * 1.79549;
            double eur = valueToConvert * 1.95583;
            double gbp = valueToConvert * 2.53405;

          /*  if (currentCurrency == "usd" && desiredCurrency == "eur")
            {
               */
                Console.WriteLine($"{valueToConvert*0.922 :F2} EUR");
            }

        }
    }
