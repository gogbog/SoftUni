using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNum = long.Parse(Console.ReadLine());
            long endNum = long.Parse(Console.ReadLine());


            List<long> primeNumbers = new List<long>();

            for (var i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }


            string line = string.Join(", ", primeNumbers.ToArray());
            Console.WriteLine(line);


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
