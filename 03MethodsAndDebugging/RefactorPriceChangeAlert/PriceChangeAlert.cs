using System;

class PriceChangeAlert
{

    // THERE'S A LOT TO MORE
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double div = GetPercentage(last, price); bool isSignificantDifference = GetDifference(div, threshold);

            string result = Get(price, last, div, isSignificantDifference);
            Console.WriteLine(result);

            last = price;
        }
    }

    private static string Get(double c, double last, double razlika, bool etherTrueOrFalse)
    {
        string to = "";
        if (razlika == 0)
        {
            to = string.Format("NO CHANGE: {0}", c);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
        return to;
    }

    private static bool GetDifference(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double GetPercentage(double l, double c)
    {
        double percentageDiff = (c - l) / l;
        return percentageDiff;
    }
}
