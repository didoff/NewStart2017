using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DayOfWeek
{
    class DayWeek
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();

            DateTime parsedDate = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(parsedDate.DayOfWeek);
        }
    }
}
