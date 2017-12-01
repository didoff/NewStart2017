using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWorkCasting
{
    class SplitByCast
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim())
                .ToList();

            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in text)
            {
                if (word.All(char.IsLower))
                    lowercase.Add(word);
                else if (word.All(char.IsUpper))
                    uppercase.Add(word);
                else if (word.Any(char.IsLetterOrDigit))
                    mixedCase.Add(word);
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowercase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", uppercase));
        }
    }
}
