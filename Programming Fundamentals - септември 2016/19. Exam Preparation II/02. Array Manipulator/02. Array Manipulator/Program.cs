using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string commandInfo = Console.ReadLine().ToLower();

                if (commandInfo.Equals("end"))
                {
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }

                string[] commandArr = commandInfo.Split();
                string command = commandArr[0];

                switch (command)
                {
                    case "exchange":

                        int commandValue = int.Parse(commandArr[1]);
                        numbers = exchangeArray(numbers, commandValue);
                        break;
                    case "max":
                        string checkEvenOdd = commandArr[1];

                        MaxEvenOddIndex(numbers, checkEvenOdd);
                        break;
                    case "min":
                        checkEvenOdd = commandArr[1];
                        MinEvenOddIndex(numbers, checkEvenOdd);
                        break;
                    case "first":
                        commandValue = int.Parse(commandArr[1]);
                        checkEvenOdd = commandArr[2];
                        GetFirstEvenOdds(numbers, commandValue, checkEvenOdd);
                        break;
                    case "last":
                        commandValue = int.Parse(commandArr[1]);
                        checkEvenOdd = commandArr[2];
                        GetLastEvenOdds(numbers, commandValue, checkEvenOdd);
                        break;

                }
            }
        }

        private static void GetLastEvenOdds(int[] numbers, int commandValue, string checkEvenOdd)
        {
            if (checkEvenOdd == "odd")
            {

                List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

                if (numbers.Length < commandValue)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }

                Console.Write("[");
                Console.Write(string.Join(", ", oddNumbers.ToArray().Reverse().Take(commandValue).Reverse()));
                Console.Write("]");
                Console.WriteLine();


            }
            else
            {
                List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

                if (numbers.Length < commandValue)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }

                Console.Write("[");
                Console.Write(string.Join(", ", evenNumbers.ToArray().Reverse().Take(commandValue).Reverse()));
                Console.Write("]");
                Console.WriteLine();

            }
        }

        private static void GetFirstEvenOdds(int[] numbers, int commandValue, string checkEvenOdd)
        {

            if (checkEvenOdd == "odd")
            {

                List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

                if (numbers.Length < commandValue)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }


                Console.Write("[");
                Console.Write(string.Join(", ", oddNumbers.Take(commandValue)));
                Console.Write("]");
                Console.WriteLine();


            }
            else
            {
                List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

                if (numbers.Length < commandValue)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }

                Console.Write("[");
                Console.Write(string.Join(", ", evenNumbers.Take(commandValue)));
                Console.Write("]");
                Console.WriteLine();


            }

        }

        private static void MinEvenOddIndex(int[] numbers, string checkEvenOdd)
        {
            
            if (checkEvenOdd == "odd")
            {
                int maxOdd = -1;
                List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
                if (oddNumbers.Count() > 0)
                {
                    maxOdd = oddNumbers.Min();
                }
                int index = Array.LastIndexOf(numbers, maxOdd);

                if (index > -1)
                {
                    Console.WriteLine(index);
                }
                else
                    Console.WriteLine("No matches");

            }
            else
            {
                int minOdd = -1;
                List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
                if (evenNumbers.Count() > 0)
                {
                    minOdd = evenNumbers.Min();
                }
                int index = Array.LastIndexOf(numbers, minOdd);

                if (index > -1)
                {
                    Console.WriteLine(index);
                }
                else
                    Console.WriteLine("No matches");
            }
        }

        private static void MaxEvenOddIndex(int[] numbers, string checkEvenOdd)
        {
            if (checkEvenOdd == "odd")
            {
                int maxOdd = -1;

                List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

                if (oddNumbers.Count() > 0)
                {
                    maxOdd = oddNumbers.Max();
                }

                int index = Array.LastIndexOf(numbers, maxOdd);

                if (index > -1)
                {
                    Console.WriteLine(index);
                }
                else
                    Console.WriteLine("No matches");

            }
            else
            {
                int minOdd = -1;
                List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
                if (evenNumbers.Count() > 0)
                {
                    minOdd = evenNumbers.Max();
                }
                int index = Array.LastIndexOf(numbers, minOdd);

                if (index > -1)
                {
                    Console.WriteLine(index);
                }
                else
                    Console.WriteLine("No matches");
            }

        }



        private static int[] exchangeArray(int[] numbers, int commandValue)
        {

            if (commandValue > numbers.Length - 1 || commandValue < 0)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            int[] arrayToTransfer = numbers.Take(commandValue + 1).ToArray();
            int[] arrayToComeDown = numbers.Skip(commandValue + 1).ToArray();
            numbers = arrayToComeDown.Concat(arrayToTransfer).ToArray();
            return numbers;
        }
    }
}
