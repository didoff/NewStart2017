using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists // maybe, just maybe it can be solved with lists instead of arrays
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split('|').ToArray();

            //List<char> result = new List<char>();

            //for (int i = input.Length - 1; i >= 0 ; i--)
            //{
            //    for (int j = 0; j < input[i].Length; j++)
            //    {
            //        if(input[i][j] != ' ')
            //        {
            //            result.Add(input[i][j]);
            //        }
            //    }
            //}

            //Console.WriteLine(String.Join(" ", result));

            /* Does not work for negative numbers. String array - "-" is included in the results.*/

            List<string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse();

            Console.WriteLine(string.Join(" ", input));

            /* Still not the best. 100/100, however empty spaces are visible.*/
        }
    }
}
