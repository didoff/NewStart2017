using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class ULogs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, int>> inputLog = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] parsedInput = input.Split(' ').ToArray();

                // Proceed maybe?
            }
        }
    }
}
