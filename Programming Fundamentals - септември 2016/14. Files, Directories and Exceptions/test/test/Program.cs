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
            string[] words = Console.ReadLine().Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0m;

            for (int i = 0; i < words.Length; i++)
            {
                sum += GetValue(words[i].Trim());
            }

            Console.WriteLine("{0:F2}", sum);

        }

        private static decimal GetValue(string word)
        {
            decimal sum = 0;
            char[] charArr = word.ToCharArray();

            int shit = int.Parse(word.Substring(1, word.Length - 2));
            sum += shit;

            if (!Char.IsUpper(charArr.First()))
            {
                sum *= ((int)charArr.First() - 96);
            }
            else
            {
                sum /= (int)charArr.First() - 64;
            }
            // malko + dr -

            if (!Char.IsUpper(charArr.Last()))
            {
                sum += (int)charArr.Last() - 96;
            }
            else
            {
                sum -= (int)charArr[charArr.Length - 1] - 64;
            }

            return sum;
        }
    }
}
