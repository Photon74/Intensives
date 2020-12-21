using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Crutches
{


    class Program
    {


        static void Main(string[] args)
        {
            // Пишу

            // Пример 1
            double a = 1, b = -26, c = 120;
            var d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1} x2 = {x2}");

            // Пример 2
            a = 2; b = 1; c = -3;
            d = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1} x2 = {x2}");

            // Пример 3
            a = 1; b = 1; c = -6;
            d = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1} x2 = {x2}");


        }
    }
}
