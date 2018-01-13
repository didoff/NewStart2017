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
            string raw = Console.ReadLine().ToLower();
            string[] input = raw.Split();
            var counts = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (counts.ContainsKey(input[i]))
                {
                    counts[input[i]]++;
                }
                else
                {
                    counts[input[i]] = 1;
                }
            }

            List<string> words = new List<string>();
            foreach (var key in counts.Keys)
            {
                if (counts[key] % 2 != 0)
                {
                    words.Add(key);
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
