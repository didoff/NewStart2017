using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHex
{
    class HexVar
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();

            decimal decValue = Convert.ToInt64(hexValue, 16);

            Console.WriteLine(decValue);
        }
    }
}
