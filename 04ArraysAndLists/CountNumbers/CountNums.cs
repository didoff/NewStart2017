using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNums
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(a => int.Parse(a)).ToList();
            input.Sort();

            int[] counts = new int[input.Max() + 1];

            foreach (var num in input)
            {
                counts[num]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if(counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }

            // Explore more ways to solve this.
        }
    }
}
