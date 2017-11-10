using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class IntHexBin
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string hexValue = Convert.ToString(input, 16);
            string binaryValue = Convert.ToString(input, 2);

            Console.WriteLine(hexValue.ToUpper());
            Console.WriteLine(binaryValue.ToUpper());
        }
    }
}
