using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumRevNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] res = new string[input.Length];
            int[] numbers = new int[input.Length];
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(ReverseString(input[i]));
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
