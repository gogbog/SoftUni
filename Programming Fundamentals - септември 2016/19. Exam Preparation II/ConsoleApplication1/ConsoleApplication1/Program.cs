using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputedInfo = Console.ReadLine().ToUpper().ToCharArray();
           

            List<char> uniqueChars = new List<char>();
            StringBuilder result = new StringBuilder(20000);
            Dictionary<int, int> numbersPosition = new Dictionary<int, int>();


            for (int i = 0; i < inputedInfo.Length ; i++)
            {
                int n;
                bool isNumeric = int.TryParse(inputedInfo[i].ToString(), out n);
                StringBuilder number = new StringBuilder(20);

                if (isNumeric)
                {
                    number.Append(inputedInfo[i]);
                    for (int z = i + 1; z < 100000; z++)
                    {
                        if (z != inputedInfo.Length && int.TryParse(inputedInfo[z].ToString(), out n))
                        {
                            number.Append(inputedInfo[z]);
                            i = z;
                        }
                        else
                        {
                            break;
                        }
                    }
                    numbersPosition.Add(i, int.Parse(number.ToString()));
                }

            }

         
            int startingPoint = 0;

            

            foreach (var numberStats in numbersPosition)
            {
                StringBuilder shit = new StringBuilder(20);

                for (int z = startingPoint; z < numberStats.Key; z++)
                {
                    int n;
                    if (int.TryParse(inputedInfo[z].ToString(), out n))
                    {
                        continue;
                    }

                    shit.Append(inputedInfo[z]);
                    uniqueChars.Add(inputedInfo[z]);
                }

                result.Append(string.Concat(Enumerable.Repeat(shit, numberStats.Value)));
                startingPoint = numberStats.Key;
            }

            Console.WriteLine("Unique symbols used: {0}", uniqueChars.Distinct().Count());

            Console.WriteLine(result);
        }
    }
}
