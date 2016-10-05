using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var i = 1; i <= number; i++)
            {
                if (i < 10)
                {
                    sum = i;
                }

                if (i >= 10)
                {
                    int secondDigit = i % 10;
                    int firstDigit = i / 10;

                    sum = secondDigit + firstDigit;
                }

                if ((sum == 5) || (sum == 7) || (sum == 11))
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }

        }
    }
}
