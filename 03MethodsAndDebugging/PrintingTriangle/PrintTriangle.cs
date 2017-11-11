using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < input+1; i++)
            {
                PrintLine(1, i);
            }

            //PrintLine(1, input);

            for (int i = input - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int number)
        {
            for (int i = start; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}
