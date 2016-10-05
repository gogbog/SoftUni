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
            string[] arrayString = Console.ReadLine().Split();
            int[] arrayNumbers = new int[arrayString.Length];

            for (int i = 0; i < arrayString.Length; i++)
            {
                arrayNumbers[i] = int.Parse(arrayString[i]);
            }

            var IsFound = false;

            for (int z = 0; z < arrayNumbers.Length; z++)
            {

                int firstNumber = arrayNumbers[z];

                for (int k = z + 1; k < arrayNumbers.Length; k++)
                {

                    int secondNumber = arrayNumbers[k];
                    int sum = firstNumber + secondNumber;
                    if (arrayNumbers.Contains(sum))
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} == {sum}");
                        IsFound = true;
                    }
                }
            }

            if (!IsFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
