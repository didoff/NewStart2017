using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BoolVar
    {
        static void Main(string[] args)
        {
            bool input = bool.Parse(Console.ReadLine());
            
            if(input == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
