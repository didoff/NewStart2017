using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Largest3Nums
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();
            //nums = nums.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
