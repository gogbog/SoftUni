using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (var i = 1; i <= number; i++)
            {
                Proverka(i);
            }

        }

        private static void Proverka(int number)
        {
            bool status1 = false;
            bool status2 = false;
            bool status3 = false;
            int sumOfDigits = 0;



            string numberString = number.ToString();



            int left = number;
            int rev = 0;

            while (left > 0)
            {
                int lastNumber = left % 10;
                rev = rev * 10 + lastNumber;
                left = left / 10;  //left = Math.floor(left / 10); 
            }

            if (rev == number)
            {
                status2 = true;
            }



            for (var k = 0; k <= numberString.Length - 1; k++)
            {

                sumOfDigits += int.Parse(numberString[k].ToString());

                if (numberString[k] % 2 == 0)
                {
                    status3 = true;
                }
            }

            if (sumOfDigits % 7 == 0)
            {
                status1 = true;
            }

            if (status1 && status2 && status3)
            {
                Console.WriteLine(number);
            }

        }
    }
}