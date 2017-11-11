using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoVar
{
    class GreaterVar
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if(input == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if(input == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                var max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if(input == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string max = GetMax(a, b);
                Console.WriteLine(max);
            }
        }

        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if(first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }

        }

            static string GetMax(string first, string second)
        {
            if(first.CompareTo(second)>= 0)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
    }
}
