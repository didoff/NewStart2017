using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class SortNum
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(a => double.Parse(a)).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
