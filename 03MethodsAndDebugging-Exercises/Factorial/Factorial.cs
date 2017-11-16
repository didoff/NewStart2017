using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factor(num));
        }

        public static BigInteger Factor(int n)
        {
            BigInteger fact = 1;

            for (int i = n; i > 1; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
