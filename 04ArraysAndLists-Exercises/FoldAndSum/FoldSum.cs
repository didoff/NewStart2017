using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();
            int k = input.Length / 4;

            int[] left = input.Take(k).ToArray();
            int[] right = input.Reverse().Take(k).ToArray();
            int[] center = input.Skip(k).Take(2 * k).ToArray();

            int[] topRow = left.Reverse().Concat(right).ToArray();
            int[] result = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                result[i] = topRow[i] + center[i];
            }

            foreach (var sum in result)
            {
                Console.Write(sum + " ");
            }
        }
    }
}
