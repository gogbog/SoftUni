using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var numberDic = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberDic.ContainsKey(numbers[i]))
                {
                    numberDic[numbers[i]]++;
                }
                else
                {
                    numberDic[numbers[i]] = 1;
                }
            }

            foreach (var item in numberDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
