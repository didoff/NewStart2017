using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInReversedOrder
{
    class ReverseNum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Reverser(input);
        }

        private static void Reverser(string input)
        {
            char[] strArr = input.ToCharArray();
            Array.Reverse(strArr);
            Console.WriteLine(strArr);
        }
    }
}
