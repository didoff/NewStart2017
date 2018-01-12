using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CharArrCompare
    {
        static void Main(string[] args)
        {
            // 80/100 - test no. 4
            char[] first = Console.ReadLine().Split().Select(a => char.Parse(a)).ToArray();
            char[] second = Console.ReadLine().Split().Select(a => char.Parse(a)).ToArray();

            int minLen = Math.Min(first.Length, second.Length);
            bool eql = true;
            bool firstAlphabetically = false;
            bool isShorter = false;

            for (int i = 0; i < minLen; i++)
            {
                if ((int)first[i] < (int)second[i])
                {
                    eql = false;
                    firstAlphabetically = true;
                }
            }

            if (first.Length <= second.Length && (int)first[0] < (int)second[0])
            {
                for (int i = 0; i < first.Length; i++)
                {
                    Console.Write(first[i]);
                }
                Console.WriteLine();

                for (int i = 0; i < second.Length; i++)
                {
                    Console.Write(second[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < second.Length; i++)
                {
                    Console.Write(second[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < first.Length; i++)
                {
                    Console.Write(first[i]);
                }
                Console.WriteLine();

            }
        }
    }
}
