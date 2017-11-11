using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfInteger
{
    class SignOfInt
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintIntSign(n);
        }

        static void PrintIntSign(int num)
        {
            if (num > 0) Console.WriteLine($"The number {num} is positive.");
            else if (num < 0) Console.WriteLine($"The number {num} is negative.");
            else Console.WriteLine($"The number {num} is zero.");
        }
    }
}
