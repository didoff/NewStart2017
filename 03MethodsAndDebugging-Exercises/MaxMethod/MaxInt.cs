using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxInt
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max1 = GetMaxValue(a, b);
            int max2 = GetMaxValue(b, c);

            int totalMax = GetMaxValue(max1, max2);
            Console.WriteLine(totalMax);
        }

        private static int GetMaxValue(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
