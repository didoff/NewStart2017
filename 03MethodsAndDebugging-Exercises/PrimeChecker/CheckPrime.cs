using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(num));
        }

        private static bool IsPrime(long num)
        {
            if (num <= 1)
                return false;

            int sqrRoot = (int)Math.Ceiling(Math.Sqrt(num));

            for (int i = 2; i <= sqrRoot; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
