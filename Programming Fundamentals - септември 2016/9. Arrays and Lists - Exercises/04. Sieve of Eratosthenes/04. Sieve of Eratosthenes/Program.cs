using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().ToArray();
            char[] arr2 = Console.ReadLine().ToArray();

            char a = 'a';
            char b = 'b';

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            //b

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine(new string(arr1));
                        Console.WriteLine(new string(arr2));
                        break;
                    }
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(new string(arr1));
                    }

                }
            }
            else if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(new string(arr2));
                Console.WriteLine(new string(arr1));
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine(new string(arr1));
                Console.WriteLine(new string(arr2));
            }
        }
    }
}
