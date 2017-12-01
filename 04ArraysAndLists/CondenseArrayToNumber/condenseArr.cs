using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class condenseArr
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

            do
            {
                if (nums.Length == 1)
                    break;

                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }

                for (int i = 0; i < condensed.Length; i++)
                {
                    nums[i] = condensed[i];
                }
                Array.Resize(ref nums, nums.Length - 1);
            }
            while (nums.Length > 1);

            Console.WriteLine(nums[0]);

        }
    }
}
