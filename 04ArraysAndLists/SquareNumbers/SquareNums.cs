using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNums
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToList();

            List<int> result = new List<int>();

            foreach (var num in input)
            {
                if(Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }

            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
