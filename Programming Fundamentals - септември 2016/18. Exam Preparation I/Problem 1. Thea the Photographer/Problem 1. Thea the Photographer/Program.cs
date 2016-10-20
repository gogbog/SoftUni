using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPictures = double.Parse(Console.ReadLine());
            double requredFilter = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double requredUpload = double.Parse(Console.ReadLine());

            double readyPics = Math.Ceiling(((double)totalPictures / 100) * percentage);

            double UplodaingTime = readyPics * requredUpload;
            double FilteringTime = totalPictures * requredFilter;
            double seconds = UplodaingTime + FilteringTime;

            TimeSpan t = TimeSpan.FromSeconds(seconds);

            string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                t.Days,
                t.Hours,
                t.Minutes,
                t.Seconds);

            Console.WriteLine(answer);


        }
    }
}
