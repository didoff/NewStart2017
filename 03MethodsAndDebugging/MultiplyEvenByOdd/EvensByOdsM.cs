using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvenByOdd
{
    class EvensByOdsM
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdd(input);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdd(int a)
        {
            int sumEvens = GetSumEven(a);
            int sumOdds = GetSumOdds(a);
            return sumEvens * sumOdds;
        }

        private static int GetSumOdds(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                int lastDigit = num % 10;
                if(lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                num /= 10;
            }

            return sum;
        }

        private static int GetSumEven(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                num /= 10;
            }

            return sum;
        }
    }
}
