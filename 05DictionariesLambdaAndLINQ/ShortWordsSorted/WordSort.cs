using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class WordSort
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char[] separators = { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' };

            string[] filteredWords = input.Split(separators).Where(w => w != "" && w.Length < 5).OrderBy(a => a).Distinct().ToArray();

            Console.WriteLine(string.Join(", ", filteredWords));
        }
    }
}
