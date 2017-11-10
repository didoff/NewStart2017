using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int till = int.Parse(Console.ReadLine());

            for (int i = 2; i <= till; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
