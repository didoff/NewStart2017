using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
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

            /*13.01 Rewite*/
            //Sum the arrays row1 and row2: var sum = row1.Select((x, index) => x + row2[index]). *As per the task*

            result = topRow.Select((x, index) => x + center[index]).ToArray();

            /* Initially done*/
            //for (int i = 0; i < 2 * k; i++)
            //{
            //    result[i] = topRow[i] + center[i];
            //}

            //foreach (var sum in result)
            //{
            //    Console.Write(sum + " ");
            //}

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
