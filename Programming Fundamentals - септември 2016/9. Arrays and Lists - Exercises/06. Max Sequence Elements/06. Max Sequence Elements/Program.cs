    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _06.Max_Sequence_Elements
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
                int biggestNumber = 0;
                int count = 0;
                int lastcount = 0;
                int biggestCount = 0;

                for (int i = 1; i < numbers.Length; i++)
                {
                    int currentNumber = numbers[i];
                    int lastNumber = numbers[i - 1];

                    if (currentNumber == lastNumber)
                    {
                        if (lastcount <= count)
                        {
                            biggestNumber = currentNumber;
                            biggestCount = count + 2;
                        }
                        count++;
                    }
                    else
                    {
                        lastcount = count;
                        count = 0;
                    }
                }

            if (biggestCount == 0)
            {
                biggestNumber = numbers[numbers.Length - 1];
                biggestCount = 1;
            }

                Console.WriteLine(String.Concat(Enumerable.Repeat(biggestNumber + " ", biggestCount)));
            }
        }
    }
