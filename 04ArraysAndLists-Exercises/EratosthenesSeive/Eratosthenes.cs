using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EratosthenesSeive
{
    class Eratosthenes
    {
        static void Main(string[] args)
        {
            int endLimit = int.Parse(Console.ReadLine());

            bool[] primes = new bool[endLimit + 1];
            primes[0] = primes[1] = false;

            for (int i = 2; i <= endLimit; i++)
            {
                primes[i] = true;
            }

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    for (int multiplier = 2; multiplier*i <= endLimit; multiplier++)
                    {
                        primes[multiplier * i] = false;
                    }

                }
            }

            for (int i = 2; i <= endLimit; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();

        }
    }
}
