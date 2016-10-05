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
            int[] fullNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int separetor = fullNumber.Length / 4;
            var firstPart = fullNumber.Take(separetor).Reverse().ToArray();
            var secondPart = fullNumber.Reverse().Take(separetor).ToArray();
            var fullPart = firstPart.Concat(secondPart).ToArray();
            var middlePart = fullNumber.Skip(separetor).Take(separetor * 2).ToArray();
            int[] sum = new int[middlePart.Length];

            for (int i = 0; i < fullPart.Length; i++)
            {
                sum[i] = fullPart[i] + middlePart[i];
            }

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
