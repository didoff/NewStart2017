using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRNumber
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                double parsedNum = double.Parse(num);

                if (counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum]++;
                }
                else
                {
                    counts[parsedNum] = 1;
                }
            }

            foreach (KeyValuePair<double, int> num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
