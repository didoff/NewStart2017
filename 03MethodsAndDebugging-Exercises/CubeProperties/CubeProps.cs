using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProps
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string aspect = Console.ReadLine();

            if (aspect == "face")
                Console.WriteLine("{0:F2}", GetCubeFaceDiagonal(side));
            else if (aspect == "space")
                Console.WriteLine("{0:F2}", GetCubeSpaceDiagonal(side));
            else if (aspect == "volume")
                Console.WriteLine("{0:F2}", GetCubeVolume(side));
            else if (aspect == "area")
                Console.WriteLine("{0:F2}", GetCubeArea(side));
        }

        private static double GetCubeArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }

        private static double GetCubeVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        private static double GetCubeSpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }

        private static double GetCubeFaceDiagonal(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }
    }
}
