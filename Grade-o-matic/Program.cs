using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_o_matic
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that gives a grade based on amount of points given

            int points = 1;
            Console.Write("Give amount of points 0-12 ");
            points = int.Parse(Console.ReadLine());
            if (points == 0 || points == 1)
                Console.WriteLine("Grade 0");
            else if (points == 2 || points == 3)
                Console.WriteLine("Grade 1");
            else if (points == 4 || points == 5)
                Console.WriteLine("Grade 2");
            else if (points == 6 || points == 7)
                Console.WriteLine("Grade 3");
            else if (points == 8 || points == 9)
                Console.WriteLine("Grade 4");
            else if (points == 10 || points == 12)
                Console.WriteLine("Grade 5");

            Console.ReadLine();
        }
    }
}
