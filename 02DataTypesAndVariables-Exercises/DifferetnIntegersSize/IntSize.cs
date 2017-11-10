using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferetnIntegersSize
{
    class IntSize
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long l;

            if (long.TryParse(input, out l))
            {
                Console.WriteLine($"{input} can fit in: ");

                sbyte s; byte b; short sh; ushort uSh; int i; uint uI; long ll;

                if (sbyte.TryParse(input, out s)) { Console.WriteLine("* sbyte"); }
                if (byte.TryParse(input, out b))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(input, out sh))
                {
                    Console.WriteLine("* short");
                }
                if(ushort.TryParse(input, out uSh))
                {
                    Console.WriteLine("* ushort");
                }
                if(int.TryParse(input, out i))
                {
                    Console.WriteLine("* int");
                }
                if (uint.TryParse(input, out uI)) Console.WriteLine("* uint");
                if (long.TryParse(input, out ll)) Console.WriteLine("* long");

            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }

            
        }
    }
}
