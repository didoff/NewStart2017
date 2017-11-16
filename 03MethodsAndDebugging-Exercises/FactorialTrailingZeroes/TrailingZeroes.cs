using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger factorial = Factor(input);
            Console.WriteLine(GetTrailingZeores(factorial));
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

        public static int GetTrailingZeores(BigInteger n)
        {
            string str = n.ToString();
            int count = 0;

            for (int i = str.Length - 1; i > 1; i--)
            {
                int lastDigit = int.Parse(str[i].ToString());

                if (lastDigit == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
