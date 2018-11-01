using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            int result = row * column;
            if (projectType == "Premiere")
            {            
                Console.WriteLine($"{(result*12):F2}");
            }else

             if (projectType == "Normal")
            {               
                Console.WriteLine($"{(result*7.50):F2}");
            }
            else
                 if(projectType == "Premiere")
            {
                Console.WriteLine($"{(result*7.50)}:F2");
            }






































        }
    }
}
