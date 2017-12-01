using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero
{
    class RoundingAwayf0
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(a => double.Parse(a)).ToArray();

            double[] roundedArr = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                roundedArr[i] = Math.Round(arr[i], 0, MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedArr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {roundedArr[i]}");
            }
        }
    }
}
