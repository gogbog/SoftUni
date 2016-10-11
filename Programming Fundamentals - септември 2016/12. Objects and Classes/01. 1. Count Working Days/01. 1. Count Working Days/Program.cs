using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startingDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime endingDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            string[] holidays = new string[] {"1-Jan", "3-Mar", "1-May", "6-May",
                                              "24-May", "6-Sep", "22-Sep", "1-Nov",
                                               "24-Dec", "25-Dec", "26-Dec" };
            int workingDays = 0;

            for (DateTime i = startingDay; i <= endingDay; i = i.AddDays(1))
            {
                string[] usless = i.ToString().Split();
                var holidayDate = usless[0].Substring(0, usless[0].Length - 3).Trim();
                bool status = true;

                for (int z = 0; z < holidays.Length; z++)
                {
                    if (holidayDate == holidays[z])
                    {
                        status = false;
                        break;
                       
                    }
                }

                if ((i.DayOfWeek.ToString() != "Saturday" && i.DayOfWeek.ToString() != "Sunday") && status)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
