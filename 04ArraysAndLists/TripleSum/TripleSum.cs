using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < i; j++)
                {
                    sum = arr[i] + arr[j + 1];

                    if (sum == arr[i])
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j+1]} == {sum}");
                    }
                }
            }

            // STILL FAR AWAY
        }
    }
}
