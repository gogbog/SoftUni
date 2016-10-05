using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troubleshooting_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = PoweredNumber(number, power);

            Console.WriteLine(result);
        }

        private static double PoweredNumber(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);

            return result;
        }


    }
}

