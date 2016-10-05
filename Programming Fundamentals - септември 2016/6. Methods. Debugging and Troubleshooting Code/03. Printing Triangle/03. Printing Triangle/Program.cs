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
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
