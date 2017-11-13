using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class CentPoint
    {
        // 80/100 in Judge; 
        // better stuff: https://pastebin.com/nMjTaqVU

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            GetCenterPoint(x1, y1, x2, y2);
        }

        private static void GetCenterPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1) < Math.Abs(x2) && Math.Abs(y1) < Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (Math.Abs(x1) > Math.Abs(x2) && Math.Abs(y1) > Math.Abs(y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (Math.Abs(x1 + y1) < Math.Abs(x2 + y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (Math.Abs(x1 + y1) > Math.Abs(x2 + y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
