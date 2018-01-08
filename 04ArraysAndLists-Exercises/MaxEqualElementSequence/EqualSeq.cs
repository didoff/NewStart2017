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
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(a => int.Parse(a))
                .ToList();

            int[] numbers = new int[input.Max() + 1];

            // OMG HAVE TO WORK THIS OUT!!!
        }
    }
}
