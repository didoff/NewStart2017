using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommEnd
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split().ToArray();
            string[] secondInput = Console.ReadLine().Split().ToArray();
            //secondInput.Reverse();

            int countLeft = 0;
            int countRight = 0;
            int currentPosition = 0;

            int maxArrLen = Math.Max(firstInput.Length, secondInput.Length);
            int minArrLen = Math.Min(firstInput.Length, secondInput.Length);

            for (int i = 0; i < minArrLen; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    currentPosition = i;
                    countLeft++;
                }
            }

            string[] revFirst = firstInput.Reverse().ToArray();
            string[] revSecond = secondInput.Reverse().ToArray();

            for (int i = 0; i < minArrLen; i++)
            {
                if (revFirst[i] == revSecond[i])
                {
                    currentPosition = i;
                    countRight++;
                }
            }

            if (countRight > countLeft)
            {
                Console.WriteLine(countRight);
            }
            else
            {
                Console.WriteLine(countLeft);
            }

        }
    }
}
