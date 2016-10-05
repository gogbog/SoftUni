using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[mainNumbers.Length];
            

            for (int i = 0; i < k; i++)
            {
                mainNumbers = ReverseNumbers(mainNumbers);

                for (int z = 0; z < sum.Length; z++)
                {
                    sum[z] += mainNumbers[z];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static int[] ReverseNumbers(int[] array)
        {
            
            int[] secondArr = new int[array.Length];
            secondArr[0] = array[array.Length - 1];

            for (int i = 1; i < secondArr.Length; i++)
            {
                secondArr[i] = array[i - 1];
            }
            return secondArr;
        }
    }
}
