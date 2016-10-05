using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int Num4 = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(Num1, Num2);

            if (maxNumber > Num4)
            {
                Console.WriteLine(maxNumber);
            }
            else
            {
                Console.WriteLine(Num4);
            }
        }

        private static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }


    }
}
