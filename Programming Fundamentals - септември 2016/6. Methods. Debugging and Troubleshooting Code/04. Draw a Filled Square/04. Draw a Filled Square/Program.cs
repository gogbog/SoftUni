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
            Console.WriteLine(new string('-', n * 2));
            Body(n);
            Console.WriteLine(new string('-', n * 2));
        }

        private static void Body(int n)
        {
            var width = n * 2;
            for (var i = 1; i < n - 1; i++)
            {

                var shit = String.Concat(Enumerable.Repeat("\\/", n - 1));
                Console.Write("-");
                Console.Write(shit);
                Console.WriteLine("-");
            }

        }
    }
}
