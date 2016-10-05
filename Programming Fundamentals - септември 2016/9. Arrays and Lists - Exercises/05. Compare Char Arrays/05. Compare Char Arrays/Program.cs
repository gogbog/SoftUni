using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Replace(" ","").ToCharArray();
            char[] arr2 = Console.ReadLine().Replace(" ", "").ToCharArray();
            bool status = false;

            if (arr1.Length < arr2.Length)
            {
                status = true;
            }

            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        status = true;
                        break;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        status = false;
                        break;
                    }
                }
            }

            if (!status)
            {
                
                Console.WriteLine(new string(arr2));
                Console.WriteLine(new string(arr1));
            }
            else
            {
                Console.WriteLine(new string(arr1));
                Console.WriteLine(new string(arr2));
            }

        }
    }
}
