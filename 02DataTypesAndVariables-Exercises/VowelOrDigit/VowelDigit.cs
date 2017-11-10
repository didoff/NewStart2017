using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class VowelDigit
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if(input == 'a' || input == 'o' || input == 'u' || input == 'e' || input == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if(char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
