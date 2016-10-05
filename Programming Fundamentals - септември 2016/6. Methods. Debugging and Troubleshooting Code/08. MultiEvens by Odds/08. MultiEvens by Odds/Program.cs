using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troubleshooting_Code
{
    class Program
    {
        static void Main()
        {
            var number = Console.ReadLine().Trim('-');
            long evenSum = 0;
            long oddSum = 0;
            long result = 0;

            for (var i = 0; i < number.Length; i++)
            {
                int numberI = int.Parse(number[i].ToString());


                if (numberI % 2 == 0)
                {
                    evenSum += numberI;
                }
                else
                {
                    oddSum += numberI;
                }


            }

            result = oddSum * evenSum;
            Console.WriteLine(result);


        }





    }
}

