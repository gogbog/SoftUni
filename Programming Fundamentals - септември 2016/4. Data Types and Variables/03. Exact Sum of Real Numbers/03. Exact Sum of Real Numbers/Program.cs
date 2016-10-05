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
            int numbers = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (var i = 0; i < numbers; i++)
            {
                decimal numberToSum = decimal.Parse(Console.ReadLine());

                sum += numberToSum;
            }
            Console.WriteLine(sum);
        }
    }
}