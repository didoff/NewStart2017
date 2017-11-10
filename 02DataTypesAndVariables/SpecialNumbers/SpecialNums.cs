using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNums
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num + 1; i++)
            {
                int sum = 0;
                int digit = i;

                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }

                bool special = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
