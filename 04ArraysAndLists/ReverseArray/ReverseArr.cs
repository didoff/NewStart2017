﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArr
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = numArr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numArr[i] + " ");
            //}

            int[] reversed = new int[numArr.Length];

            for (int i = 0; i < numArr.Length; i++)
            {
                reversed[i] = numArr[numArr.Length - 1 - i];
            }

            foreach (var number in reversed)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }
    }
}
