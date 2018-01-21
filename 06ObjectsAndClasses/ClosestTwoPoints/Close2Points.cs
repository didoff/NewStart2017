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

            double result = FindClosestPoints(allPoints);
            Console.WriteLine(result);


        }

        private static double FindClosestPoints(Point[] points)
        {
            double[] distances = new double[points.Length - 1];
            double minDistance = double.MaxValue;
            int position = 0;
            for (int i = 1; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    distances[i] = CalculatePointDistance(points[i - 1], points[j]); // compare each
                }
            }

            // To return Point[] array with the closest points and their distance!
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

            double euclDist = Math.Sqrt(deltaA * deltaA + deltaB * deltaB);
            return euclDist;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
