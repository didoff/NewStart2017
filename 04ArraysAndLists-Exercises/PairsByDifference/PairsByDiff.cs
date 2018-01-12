using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDiff
    {
        static void Main(string[] args)
        {
            int[] numSeqence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            //List<int> results = new List<int>();
            int count = 0;

            for (int i = 0; i < numSeqence.Length; i++)
            {
                for (int j = i + 1; j < numSeqence.Length; j++)
                {
                    if (difference == Math.Abs(numSeqence[i] - numSeqence[j]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
