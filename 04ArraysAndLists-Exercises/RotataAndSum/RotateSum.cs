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
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k - 1; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {

                }
            }

        }
    }
}
