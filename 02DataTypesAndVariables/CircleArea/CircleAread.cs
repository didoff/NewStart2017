﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class CircleAread
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine("{0:f12}", area);
        }
    }
}
