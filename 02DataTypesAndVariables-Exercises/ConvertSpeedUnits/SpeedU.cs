using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class SpeedU
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            /*
             * hour 1 = 60 min = 3600 sec
             */

            double hoursToSecond = (double)hours * 60 * 60;
            double minToSecond = (double)minutes * 60;

            double total = seconds + minToSecond + hoursToSecond;
            double metersPerSecond = (double)distance / total;
            double kph = (double)metersPerSecond * 3.6;

            double distanceInMile = (double)distance * 1309;

            double milesPerHour = kph * 0.6213;

            Console.WriteLine("{0:F6}", metersPerSecond);
            Console.WriteLine("{0:F6}", kph);
            Console.WriteLine("{0:F6}", milesPerHour);
        }
    }
}
