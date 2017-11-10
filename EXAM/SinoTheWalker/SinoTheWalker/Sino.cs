using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Sino
    {
        static void Main(string[] args)
        {
            string leaveTime = Console.ReadLine();
            int steps = int.Parse(Console.ReadLine());
            int secondsForStep = int.Parse(Console.ReadLine());

            DateTime leaveT = DateTime.ParseExact(leaveTime, "HH:mm:ss", CultureInfo.InvariantCulture);

            int allSeconds = steps * secondsForStep;

            DateTime finalTime = leaveT.AddSeconds(Convert.ToDouble(allSeconds));

            /*
            if(finalTime.Hour < 10)
            {
                Console.WriteLine("Time Arrival: 0{0:HH:mm:ss}", finalTime);
            }
            */

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", finalTime);

        }
    }
}
