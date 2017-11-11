using System;

namespace HelloName
{
    class hello
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            PrintHelloName(name);
        }

        private static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
