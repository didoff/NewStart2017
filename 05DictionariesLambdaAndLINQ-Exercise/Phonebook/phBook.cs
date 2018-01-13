using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class phBook
    {
        static void Main(string[] args)
        {
            string[] commandLine = Console.ReadLine().Split().ToArray();
            string command = commandLine[0];

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                if (command == "A")
                {
                    phonebook[commandLine[1]] = commandLine[2];
                }
                else if(command == "S")
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

                commandLine = Console.ReadLine().Split().ToArray();
                command = commandLine[0];
            }


        }
    }
}
