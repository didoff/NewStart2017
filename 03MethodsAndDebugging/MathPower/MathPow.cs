using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPow
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            double result = MathPower(num, pow);

            Console.WriteLine(result);
        }

        static double MathPower(double n, int power)
        {
            return Math.Pow(n, power);
        }
    }
}
