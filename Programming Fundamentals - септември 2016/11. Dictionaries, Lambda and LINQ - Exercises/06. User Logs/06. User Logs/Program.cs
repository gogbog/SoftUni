using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main()
        {
            var dict = new SortedDictionary<string, List<string, int>>();
            dict.Add("shit", new List<string, int>());
            dict["shit"].Add("milq kitich", 5);

            foreach (var dictData in dict)
            {
                var sortedSingers = dictData.Value.OrderBy(x => x.Value).ToList();
                Console.WriteLine(dictData.Key);

                foreach (var SingerData in sortedSingers)
                {
                    Console.WriteLine($"{SingerData.Key} -. {SingerData.Value}");
                }
            }
        }
    }
}