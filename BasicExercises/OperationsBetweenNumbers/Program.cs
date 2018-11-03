using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string operatr = Console.ReadLine();
            

           if(operatr == "+")
            {
                if((n1+n2)%2==0)
                {
                    Console.WriteLine($"{n1} + {n2} = {n1+n2} - even");
                }else
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2} - odd");
            }

           else

           if (operatr == "-")
            {
                if ((n1 - n2) % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2} - even");
                }
                else
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2} - odd");
            }

            else

            if (operatr == "*")
            {
                if ((n1 * n2) % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2} - even");
                }
                else
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2} - odd");
            }

            else

            if (operatr == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }else
                Console.WriteLine($"{n1} / {n2} = {n1 / n2:F2} ");
            }

           else

             if (operatr == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2} ");
            }
           
















        }
    }
}
