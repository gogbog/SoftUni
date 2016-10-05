using System;
using System.Numerics;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            int sum1 = 0;
            int sum2 = 0;

            if (arr1.Length >= arr2.Length)
            {
                int diff = arr1.Length - arr2.Length;
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        break;
                    }
                    else
                    {
                        sum1++;
                    }
                }
                for (int i = arr2.Length - 1; i >= 0; i--)
                {
                    if (arr1[i + diff] != arr2[i])
                    {
                        break;
                    }
                    else
                    {
                        sum2++;
                    }
                }
            }
            else
            {
                int diff = arr2.Length - arr1.Length;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        break;
                    }
                    else
                    {
                        sum1++;
                    }
                }
                for (int i = arr1.Length - 1; i >= 0; i--)
                {
                    if (arr1[i] != arr2[i + diff])
                    {
                        break;
                    }
                    else
                    {
                        sum2++;
                    }
                }
            }
            if (sum1 >= sum2)
            {
                Console.WriteLine(sum1);
            }
            else
            {
                Console.WriteLine(sum2);
            }
        }
    }
}