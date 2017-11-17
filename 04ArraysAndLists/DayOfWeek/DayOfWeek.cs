using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());
            
            if (input > 0 && input < 8)
            {
                Console.WriteLine(days[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

            }
        }
    }
