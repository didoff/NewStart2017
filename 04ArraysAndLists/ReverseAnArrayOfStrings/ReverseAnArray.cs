using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class ReverseAnArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            //string[] reversed = new string[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    reversed[i] = arr[arr.Length - 1 - i];
            //}

            //foreach (var stringarr in reversed)
            //{
            //    Console.Write(stringarr + " ");
            //}
            //Console.WriteLine();

            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
