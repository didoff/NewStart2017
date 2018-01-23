using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Close2Points
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] allPoints = new Point[n];

            for (int i = 0; i < n; i++)
            {
                allPoints[i] = ReadPoint();
            }

            Point[] result = FindClosestPoints(allPoints);
            double dist = CalculatePointDistance(result[0], result[1]);
            Console.WriteLine($"{dist:F3}");
            Console.WriteLine($"({result[0].X}, {result[0].Y})");
            Console.WriteLine($"({result[1].X}, {result[1].Y})");
        }

        private static Point[] FindClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestPoints = null;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalculatePointDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints = new Point[] { points[i], points[j] };
                    }
                }
            }

            return closestPoints; // To return Point[] array with the closest points and their distance!
        }

        private static Point ReadPoint()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];

            return point;
        }

        private static double CalculatePointDistance(Point p1, Point p2)
        {
            int deltaA = p1.X - p2.X;
            int deltaB = p1.Y - p2.Y;

            return Math.Sqrt(deltaA * deltaA + deltaB * deltaB);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
