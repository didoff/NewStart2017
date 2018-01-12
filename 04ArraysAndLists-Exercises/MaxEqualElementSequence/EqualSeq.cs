using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEqualElementSequence
{
    class EqualSeq
    {
        static void Main(string[] args)
        {

            // OH COME ON!!

            int[] sequence = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();

            int start = 0;
            int lenght = 1;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                if(sequence[i - 1] == sequence[i])
                {
                    lenght++;
                    if (lenght > bestLength)
                    {
                        start = lenght - 1;
                        bestLength = lenght;
                    }
                }
                else
                {
                    lenght = 0;
                }

            }

            for (int i = start; i < bestLength + 1; i++)
            {
                Console.WriteLine(sequence[i]);
            }
            
        }
    }
}
