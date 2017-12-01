using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class ArrSum
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

            //int maxLen = Math.Max(arr1.Length, arr2.Length);
            int[] resultArr = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = arr1[i%arr1.Length] + arr2[i%arr2.Length];
            }

            foreach (var num in resultArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
