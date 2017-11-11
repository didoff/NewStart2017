using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class SquarePrint
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintHeaderFooter(input);
            for (int i = 0; i < input - 2; i++)
            {

                PrintMiddleRows(input);
            }
            PrintHeaderFooter(input);
        }


        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string ('-', 2 * n));
        }

        static void PrintMiddleRows(int n)
        {
            Console.Write('-');

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }


    }
}
