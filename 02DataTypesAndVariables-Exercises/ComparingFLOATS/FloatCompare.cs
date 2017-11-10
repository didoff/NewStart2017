using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFLOATS
{
    class FloatCompare
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = Math.Abs(a - b);

            if(c < 0.000001)
            {
                Console.WriteLine("True");
            }
            else if(c >= 0.000001)
            {
                Console.WriteLine("False");
            }
        }
    }
}
