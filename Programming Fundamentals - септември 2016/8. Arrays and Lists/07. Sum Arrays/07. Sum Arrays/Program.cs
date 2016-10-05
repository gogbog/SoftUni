using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = 0;
            int shit1 = array1.Length;
            int shit2 = array2.Length;

            if (array1.Length != array2.Length)
                diff = array1.Length - array2.Length;

            if (diff > 0)
            {
                Array.Resize<int>(ref array2, array1.Length);
                diff = Math.Abs(diff);
                int count = 0;
                //array1 e po golqm
                for (int i = 0; i < diff; i++)
                {
                    if (count == diff)
                    {
                        count = 0;
                    }
                    array2[shit2 + count] = array2[count];

                    count++;
                }
            }
            else if (diff < 0)
            {
                //arrray2 e po golqm

                Array.Resize<int>(ref array1, array2.Length);
                diff = Math.Abs(diff);
                int count = 0;
                //array1 e po golqm
                for (int i = 0; i < diff; i++)
                {
                    if (count == diff)
                    {
                        count = 0;
                    }
                    array1[shit1 + count] = array1[count];

                    count++;
                }
            }

            CalculateTheArrays(array1, array2);


        }

        private static void CalculateTheArrays(int[] arrayString1, int[] arrayString2)
        {
            for (int i = 0; i < arrayString1.Length; i++)
            {
                Console.Write($"{arrayString1[i] + arrayString2[i]} ");
            }
            Console.WriteLine();
        }
    }
}
