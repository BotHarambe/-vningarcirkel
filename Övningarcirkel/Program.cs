using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningarcirkel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många cirklar?");
            int numCircles = int.Parse(Console.ReadLine());

            var circles = new Circle[numCircles];

            for (int i = 0; i < numCircles; i++)
            {
                Console.WriteLine("skriv radie av cirkeln " + (i + 1) + ":");
                double radius = double.Parse(Console.ReadLine());

                circles[i] = new Circle(radius);
            }

            foreach (Circle c in circles)
            {
                Console.WriteLine(c.ToString());
            }
            Console.ReadLine();
        }
    }


    }

