using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double resultRoses = countFlowers * 5;
            double resultDahlias = countFlowers * 3.80;
            double resultTulips = countFlowers * 2.80;
            double resultNarcissus = countFlowers * 3.00;
            double resultGladiolus = countFlowers * 2.50;

            if (flowerType == "Roses" && budget > resultRoses)
            {
                if (countFlowers > 80)
                {
                    double discount = (resultRoses * 10) / 100;
                    Console.WriteLine($"Hey, you have a great garden with {resultRoses:F2} Roses and {((budget - resultRoses) - discount):F2} leva left.");
                }
                else
                    Console.WriteLine($"Hey, you have a great garden with {resultRoses:F2} Roses and {(budget - resultRoses):F2} leva left.");
            }
            else
                if (flowerType == "Roses" && budget < resultRoses)
            {
                Console.WriteLine($"Not enough money, you need {(Math.Abs(budget - resultRoses)):F2} leva more.");
            }

            else



            if (flowerType == "Dahlias" && budget > resultDahlias)
            {

                if (countFlowers > 90)
                {
                    double discount = (resultDahlias * 15) / 100;
                    Console.WriteLine($"Hey, you have a great garden with {countFlowers} Dahlias and {Math.Abs((resultDahlias - budget) - discount):F2} leva left.");
                }
                else
                    Console.WriteLine($"Hey, you have a great garden with {countFlowers:F2} Dahlias and {(budget - resultDahlias):F2} leva left.");
            }
            else
                if (flowerType == "Dahlias" && budget < resultDahlias)
            {
                Console.WriteLine($"Not enough money, you need {(Math.Abs(budget - resultDahlias)):F2} leva more.");
            }

            else











            if (flowerType == "Tulips" && budget > resultTulips)
            {

                if (countFlowers > 80)
                {
                    double discount = (resultTulips * 15) / 100;
                    Console.WriteLine($"Hey, you have a great garden with {countFlowers} Tulips and {Math.Abs((resultTulips - budget) - discount):F2} leva left.");
                }
                else
                    Console.WriteLine($"Hey, you have a great garden with {resultTulips:F2} Roses and {(budget - resultTulips):F2} leva left.");
            }
            else
           if (flowerType == "Tulips" && budget < resultTulips)
            {

                Console.WriteLine($"Not enough money, you need {(Math.Abs(budget - resultTulips)):F2} leva more.");
            }

            else













             if (flowerType == "Narcissus" && budget > (resultNarcissus + resultNarcissus))
            {

                if (countFlowers < 120)
                {
                    double more = (resultNarcissus * 15) / 100;
                    Console.WriteLine($"Hey, you have a great garden with {countFlowers} Narcissus and {Math.Abs((resultNarcissus - budget) + more):F2} leva left.");
                }
                else
                    Console.WriteLine($"Hey, you have a great garden with {countFlowers:F2} Narcissus and {(resultNarcissus - budget):F2} leva left.");
            }
            else
           if (flowerType == "Narcissus" && budget < (resultNarcissus + resultNarcissus))
            {
                double more = (resultNarcissus * 15) / 100;
                Console.WriteLine($"Not enough money, you need {(Math.Abs((resultNarcissus + more) - budget)):F2} leva more.");
            }

            else













             if (flowerType == "Gladiolus" && budget > (resultGladiolus + resultGladiolus))
            {

                if (countFlowers < 120)
                {
                    double more = (resultGladiolus * 20) / 100;
                    Console.WriteLine($"Hey, you have a great garden with {countFlowers} Narcissus and {Math.Abs((resultGladiolus - budget) + more):F2} leva left.");
                }
                else
                    Console.WriteLine($"Hey, you have a great garden with {countFlowers:F2} Narcissus and {(resultGladiolus - budget):F2} leva left.");
            }
            else
           if (flowerType == "Gladiolus" && budget < (resultGladiolus + resultGladiolus))
            {
                double more = (resultGladiolus * 20) / 100;
                Console.WriteLine($"Not enough money, you need {(Math.Abs((resultGladiolus+more)-budget)):F2} leva more.");
            }



















        }
    }
}
