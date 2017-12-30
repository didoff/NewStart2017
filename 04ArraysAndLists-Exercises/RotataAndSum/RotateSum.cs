using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotataAndSum
{
    class RotateSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();
            int r = int.Parse(Console.ReadLine());

            int[] sumRotaion = new int[input.Length];

            for (int i = 0; i < r; i++)
            {
                int lastNum = input[input.Length - 1];

                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }

                input[0] = lastNum;

                for (int k = 0; k < input.Length; k++)
                {
                    sumRotaion[k] += input[k];
                }
            }

            Console.WriteLine(string.Join(" ", sumRotaion));

        }
    }
}
