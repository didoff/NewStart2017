using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class phBookUpgr
    {
        static void Main(string[] args)
        {
            string[] commandLine = Console.ReadLine().Split().ToArray();
            string command = commandLine[0];

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                if (command == "A")
                {
                    phonebook[commandLine[1]] = commandLine[2];
                }
                else if (command == "S")
                {
                    string NValue = "";
                    if (phonebook.TryGetValue(commandLine[1], out NValue))
                    {
                        Console.WriteLine($"{commandLine[1]} -> {NValue}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commandLine[1]} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (KeyValuePair<string,string> entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }

                commandLine = Console.ReadLine().Split().ToArray();
                command = commandLine[0];
            }
        }
    }
}
