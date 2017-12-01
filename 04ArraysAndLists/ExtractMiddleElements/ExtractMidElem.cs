using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class ExtractMidElem
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
            int n = elements.Length;

            if(n == 1)
            {
                Console.WriteLine(elements[0]);
            }
            else if(n % 2 != 0)
            {
                Console.WriteLine($"{{ {elements[n/2 -1]}, {elements[n/2]}, {elements[n/2 + 1]} }}");
            }
            else if(n % 2 == 0)
            {
                Console.WriteLine($"{{ {elements[n / 2 - 1]}, {elements[n / 2]} }}");

            }
        }
    }
}
