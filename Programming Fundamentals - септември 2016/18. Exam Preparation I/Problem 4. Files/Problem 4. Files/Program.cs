using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var mainDict = new Dictionary<string, Dictionary<string, long>>();
            // games keygen.exe 1102

            for (int i = 0; i < n; i++)
            {
                string path = Console.ReadLine();

                string[] firstSpl = path.Split(';');
                long number = long.Parse(firstSpl[1]);
                string[] secondSpl = firstSpl[0].Split('\\');


                //ot tuk
                if(!mainDict.ContainsKey(secondSpl[0]))
                {
                    mainDict.Add(secondSpl[0], new Dictionary<string, long>());
                }

                if (!mainDict[secondSpl[0]].ContainsKey(secondSpl[secondSpl.Length - 1]))
                {
                    mainDict[secondSpl[0]].Add(secondSpl[secondSpl.Length - 1], 0);
                }


                mainDict[secondSpl[0]][secondSpl[secondSpl.Length - 1]] = number;

                //do tuk
            }

            string[] search = Console.ReadLine().Split();

            string type = search[0];
            string direct = search[2];
            bool status = true;

            var list = mainDict.Where(x => x.Key == direct).ToList();

            foreach (var fileData in list)
            {
                var shitList = fileData.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

                foreach (var item in shitList)
                {
                    var extension = item.Key.Split('.').Last();

                    if (extension == type)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                        status = false;
                    }
                }
            }

            if (status)
            {
                Console.WriteLine("No");
            }

        }
    }
}
