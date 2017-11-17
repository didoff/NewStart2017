using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSequence
{
    class LastKnumSeq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            PrintKSeqence(n, k);
        }

        private static void PrintKSeqence(int n, int k)
        {
            int[] seq = new int[n];
            seq[0] = 1;

            for (int i = 1; i < seq.Length; i++)
            {
                //int sum = 0;

                for (int j = 0; j < i - k; j++)
                {
                    seq[i] += seq[i - k];
                }
                Console.WriteLine(seq[i]);
            }
        }
    }
}
