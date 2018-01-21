using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class DistBNPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double result = CalculatePointDistance(p1, p2);

            Console.WriteLine("Distance: {0:f3}", result);
        }


        private static double CalculatePointDistance(Point p1, Point p2)
        {
            int deltaA = p1.X - p2.X;
            int deltaB = p1.Y - p2.Y;

            double euclDist = Math.Sqrt(deltaA * deltaA + deltaB * deltaB);
            return euclDist;
        }

        private static Point ReadPoint()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];

            return point;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
