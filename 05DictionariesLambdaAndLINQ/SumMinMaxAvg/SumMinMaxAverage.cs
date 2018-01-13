using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAvg
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            double[] input = new double[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {input.Sum()}");
            Console.WriteLine($"Min = {input.Min()}");
            Console.WriteLine($"Max = {input.Max()}");
            Console.WriteLine($"Average = {input.Average()}");
        }
    }
}
