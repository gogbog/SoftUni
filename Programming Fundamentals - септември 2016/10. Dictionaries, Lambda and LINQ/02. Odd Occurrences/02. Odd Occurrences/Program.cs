using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] stringArr = Console.ReadLine().ToLower().Split().ToArray();
            var count = new Dictionary<string, int>();

            for (int i = 0; i < stringArr.Length; i++)
            {
                if (count.ContainsKey(stringArr[i]))
                {
                    count[stringArr[i]]++;
                }
                else
                {
                    count[stringArr[i]] = 1;
                }
            }

            var list = new List<string>();

            foreach (var item in count.Keys)
            {
                if (count[item] % 2 != 0)
                {
                    list.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ",list));
        }
    }
}
