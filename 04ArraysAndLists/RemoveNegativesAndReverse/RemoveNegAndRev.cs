using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegAndRev
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToList();
            elements.Reverse();

            List<int> result = new List<int>();
            bool hasPositive = false;

            foreach (var item in elements)
            {
                if (item >= 0)
                {
                    result.Add(item);
                    hasPositive = true;
                }
            }

            if (hasPositive == true)
                Console.WriteLine(String.Join(" ", result));
            else
                Console.WriteLine("empty");
        }
    }
}
