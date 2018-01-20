using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RndWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int random = rnd.Next(input.Length - 1);

                string oldValue = input[i];
                input[i] = input[random];
                input[random] = oldValue;
            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
