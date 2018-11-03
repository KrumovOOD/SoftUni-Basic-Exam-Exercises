using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            
            DateTime hmExam = DateTime.ParseExact($"{hourExam}:{minuteExam}", "H:m", null);
            DateTime hmArrive = DateTime.ParseExact($"{hourArrive}:{minuteArrive}", "H:m", null);

            int dateTimeResult = DateTime.Compare(hmExam, hmArrive);
            System.TimeSpan difference = hmExam - hmArrive;

           
           


            if (dateTimeResult<0)
            {
               
                Console.WriteLine("Late");
                Console.WriteLine($"{difference:h\\:mm}  hours after the start");
            }

           else

             if (dateTimeResult == 0 || minuteArrive>=30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{difference:\\:m}  minutes before the start");

            }

            else

            if (minuteArrive<=30)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{difference:h\\:mm}  hours before the start");
            }

















        }
    }
}
