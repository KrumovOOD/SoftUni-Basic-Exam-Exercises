﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStatistic
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort minutes = ushort.Parse(Console.ReadLine());
            string playerName = Console.ReadLine();


            if (minutes == 0)
            { Console.WriteLine("Match has just began!"); }


            if (minutes < 45)
            { Console.WriteLine("First half time."); }

            if (minutes >= 45)
            { Console.WriteLine("Second half time."); }


            if (minutes >= 1 && minutes <= 10 && minutes % 2 == 0)
            {
                Console.WriteLine(playerName + " missed a penalty.");
                Console.WriteLine(playerName + " was injured after the penalty.");
            }
            else if (minutes >= 1 && minutes <= 10 && minutes % 2 != 0)
            { Console.WriteLine(playerName + " missed a penalty."); }


            if (minutes > 10 && minutes <= 35 && minutes % 2 != 0)
            {
                Console.WriteLine(playerName + " received yellow card.");
                Console.WriteLine(playerName + " got another yellow card.");
            }
            else if (minutes > 10 && minutes <= 35)
            {
                Console.WriteLine(playerName + " received a yellow card.");
            }

            if (minutes > 35 && minutes < 45)
            {
                Console.WriteLine(playerName + " SCORED A GOAL !!!");

            }

            if (minutes > 45 && minutes <= 55 && minutes % 2 == 0)
            {
                Console.WriteLine(playerName + " got a free kick");
                Console.WriteLine(playerName + " missed the freekick.");
            }
            else if (minutes > 45 && minutes <= 55)
            { Console.WriteLine(playerName + " got a free kick"); }


            if (minutes > 55 && minutes <= 80 && minutes % 2 != 0)
            {
                Console.WriteLine(playerName + " missed a shot from corner.");
                Console.WriteLine(playerName + " has been changed with another player.");
            }
            else if (minutes > 55 && minutes <= 80)
            { Console.WriteLine(playerName + " missed a shot from corner."); }



            if (minutes > 80 && minutes <= 90)
            {
                Console.WriteLine(playerName + " SCORED A GOAL FROM PENALTY !!!");

            }




        }


    }


}
