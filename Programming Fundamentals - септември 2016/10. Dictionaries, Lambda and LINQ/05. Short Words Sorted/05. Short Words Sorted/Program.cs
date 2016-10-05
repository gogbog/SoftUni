using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', '.', ';', '(', ')', '[', ']', '"', '/', '\\', '!', '?', ' ', '\'' };
            string[] stringArr1 = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5)
                .OrderBy(word => word)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", stringArr1));

        }
    }
}
