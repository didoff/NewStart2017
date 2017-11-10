using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumRealNumbers
{
    class ExactSumRnum
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
