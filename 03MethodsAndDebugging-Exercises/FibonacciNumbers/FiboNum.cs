using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FiboNum
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int fiboResult = GetNFiboNumber(input);
            Console.WriteLine(fiboResult);
        }

        private static int GetNFiboNumber(int input)
        {
            int a = 1;
            int b = 1;
            
            for (int i = 0; i < input; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
