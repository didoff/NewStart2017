using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class TheaThePhoto
    {
        static void Main(string[] args)
        {
            int numberOfPics = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            decimal usefulPics = (numberOfPics * filterFactor) / 100;
            usefulPics = Math.Ceiling(usefulPics);
            int totalProcessingTime = numberOfPics * filterTime;
            decimal totalUploadTime = (usefulPics) * uploadTime;

            int total = totalProcessingTime + (int)totalUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(total);

            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}
