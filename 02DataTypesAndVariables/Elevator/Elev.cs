using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elev
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourse = people / capacity;
            int partialCource = people % capacity;

            //Console.WriteLine(fullCourse);
            //Console.WriteLine(partialCource);

            if(partialCource > 0 && partialCource < capacity)
            {
                fullCourse += 1;
            }

            Console.WriteLine(fullCourse);
        }
    }
}
