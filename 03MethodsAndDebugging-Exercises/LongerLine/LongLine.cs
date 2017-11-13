using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class LongLine
    {
        // 60/100 in JUDGE; check again 
        // ** reuse CenterPoint!

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintPointClosestToOrigin(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void PrintPointClosestToOrigin(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lenght1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double lenght2 = Math.Sqrt(Math.Pow(x3 - y3, 2) + Math.Pow(x4 - y4, 2));

            if (lenght1 >= lenght2)
            {
                double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

                if (distance1 <= distance2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double distance3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
                double distance4 = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

                if (distance3 <= distance4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }

            }

        }

    }
}
