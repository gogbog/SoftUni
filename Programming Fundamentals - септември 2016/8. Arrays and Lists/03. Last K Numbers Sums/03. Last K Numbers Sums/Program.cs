using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;

            for (int i = 1; i < array.Length; i++)
            {
                long sum = 0;
                int count = k;

                for (int z = i - 1; z >= 0; z--)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    sum += array[z];
                    count--;
                }

                array[i] = sum;
            }

            for (int f = 0; f < n; f++)
            {
                Console.WriteLine(array[f]);
            }
        }
    }
}
