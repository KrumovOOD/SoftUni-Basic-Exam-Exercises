using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double result, result1, result2;

            if (number <= 100)
            {
                if (number % 2 == 0)
                {
                    result = number + 5 + 1;
                    result1 = 5 + 1;
                    Console.WriteLine(result1);
                    Console.WriteLine(result);
                }
                else
                    if (number % 2 != 0)
                {
                    if (number%10 == 5)
                    {
                        double result3 = 5 + 2;
                        Console.WriteLine(result3);
                        Console.WriteLine(result3+number);
                    }
                   

                    
                }
            }
            else


                if (number > 100 && number < 1000)
            {
                if (number % 2 == 0)
                {
                    result1 = ((number * 20) / 100) + 1;
                    Console.WriteLine(result1);
                    Console.WriteLine(result1 + number);
                }
                else
                if (number % 2 != 0)
                {
                    result1 = ((number * 20) / 100);
                    Console.WriteLine(number);
                    Console.WriteLine(result1 + number);
                }
            }
            else
                 if (number > 1000)
            {
                if (number % 2 == 0)
                {
                    result1 = ((number * 10) / 100) + 1;
                    Console.WriteLine(number);
                    Console.WriteLine(result1 + number);
                }
                else
                if (number % 2 != 0)
                {

                    result2 = ((number * 10) / 100);
                    Console.WriteLine(result2);
                    Console.WriteLine(result2 + number);

                }
            }


        }
    }
}