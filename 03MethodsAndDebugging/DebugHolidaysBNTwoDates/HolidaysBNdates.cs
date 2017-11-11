using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);  // old value "dd.m.yyyy"
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);

        int holidaysCount = 0;

        for (var date = startDate; date <= endDate; date = date.AddDays(1)) // old value "; AddDays(1)"
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) // old value && AND
                holidaysCount++;

        Console.WriteLine(holidaysCount);
    }
}