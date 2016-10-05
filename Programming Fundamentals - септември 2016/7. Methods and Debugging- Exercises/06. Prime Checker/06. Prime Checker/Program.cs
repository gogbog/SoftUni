using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static bool IsPrime(long number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            int shit = (int)Math.Floor(Math.Sqrt(number));

            for (var i = 2; i <= shit; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
