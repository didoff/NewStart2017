using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeoCalc
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                TriangleArea();
            }
            else if (figureType == "square")
                SquareArea();
            else if (figureType == "rectangle")
                RectangleArea();
            else if (figureType == "circle")
                CircleArea();
        }

        private static void CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Math.PI * radius * radius);
        }

        private static void RectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", width * height);
        }

        private static void SquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", side * side);
        }

        private static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", (side * height) / 2);
        }
    }
}
