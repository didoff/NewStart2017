using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrManipulator
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandLine = Console.ReadLine().Split().ToArray();
            string command = commandLine[0].ToString();
            int[] arguments = commandLine.Skip(1).Select(int.Parse).ToArray();

            while(command != "print")
            {
                switch (command)
                {
                    case "add":
                        inputList.Insert(arguments[0], arguments[1]);
                        break;
                    case "addMany":
                        inputList.InsertRange(arguments[0], arguments.Skip(1));
                        break;
                    case "contains":
                        Console.WriteLine(inputList.Contains(arguments[0])); // True/False to be converted to "0" / "-1".
                        break;
                    case "remove":
                        inputList.RemoveAt(arguments[0]);
                        break;
                    case "shift":
                        inputList = new List<int> (ShiftByPosition(arguments[0], inputList));
                        break;
                    case "sumPairs":

                        break;
                    default:
                        Console.WriteLine("Please enter a valid command!");
                        break;
                }

                commandLine = Console.ReadLine().Split().ToArray();
                command = commandLine[0].ToString();

            }

            Console.WriteLine(string.Join(" ", inputList));
        }

        private static List<int> ShiftByPosition(int rotationTimes, List<int> numbers)
        {
            // Taken from Rotate and Sum assignment.

            for (int i = 0; i < rotationTimes; i++)
            {
                int lastNum = numbers[numbers.Count - 1];

                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = lastNum;
            }

            return numbers;
        }
    }
}
