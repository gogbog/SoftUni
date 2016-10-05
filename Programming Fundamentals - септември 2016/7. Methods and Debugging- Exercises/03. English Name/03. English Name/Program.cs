using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int shit = int.Parse(number[number.Length - 1].ToString());

            string numberWord = NumberToWord(shit);

            Console.WriteLine(numberWord);
        }


        private static string NumberToWord(int number)
        {

            if (number == 1)
            {
                return "one";
            }
            else if (number == 2)
            {
                return "two";
            }
            else if (number == 3)
            {
                return "three";
            }
            else if (number == 4)
            {
                return "four";
            }
            else if (number == 5)
            {
                return "five";
            }
            else if (number == 6)
            {
                return "six";
            }
            else if (number == 7)
            {
                return "seven";
            }
            else if (number == 8)
            {
                return "eight";
            }
            else if (number == 9)
            {
                return "nine";
            }

            return "zero";
        }
    }
}
