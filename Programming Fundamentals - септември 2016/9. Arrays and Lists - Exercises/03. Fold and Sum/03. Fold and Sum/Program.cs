using System;
using System.Linq;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstPart = new int[(numbers.Length / 4)];
            int[] secondPart = new int[(numbers.Length / 4)];
            int[] joinedPart = new int[numbers.Length / 2];
            int[] middlePart = new int[numbers.Length / 2];

            CalculateFirstPart(firstPart, numbers);
            CalculateSecondPart(secondPart, numbers);
            JoinTwoArrays(firstPart, secondPart, joinedPart);
            GetMiddlePart(middlePart, numbers);
            CalculateTheResult(joinedPart, middlePart);


        }

        private static void CalculateTheResult(int[] joinedPart, int[] middlePart)
        {
            for (int i = 0; i < joinedPart.Length; i++)
            {
                Console.Write(joinedPart[i] + middlePart[i] + " ");
            }
            Console.WriteLine();
        }

        private static void GetMiddlePart(int[] middlePart, int[] numbers)
        {
            int sidePart = numbers.Length / 4;
            int count = 0;
            for (int i = sidePart; i < numbers.Length - sidePart; i++)
            {
                middlePart[count] = numbers[i];
                count++;
            }
        }

        private static void JoinTwoArrays(int[] firstPart, int[] secondPart, int[] bigPart)
        {
            int width = firstPart.Length;
            int count = 0;

            for (int i = 0; i < bigPart.Length; i++)
            {
                if (i < width)
                {
                    bigPart[i] = firstPart[i];
                }
                else
                {
                    bigPart[i] = secondPart[count];
                    count++;
                }

            }
        }

        private static void CalculateFirstPart(int[] part, int[] numbers)
        {
            int neededNumbers = numbers.Length / 4;
            int count = 0;

            for (int i = neededNumbers - 1; i >= 0; i--)
            {
                part[count] = numbers[i];
                count++;
            }
        }

        private static void CalculateSecondPart(int[] part, int[] numbers)
        {
            int neededNumbers = numbers.Length / 4;
            int count = 0;

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (count == neededNumbers)
                {
                    break;
                }

                part[count] = numbers[i];
                count++;
            }
        }


    }
}