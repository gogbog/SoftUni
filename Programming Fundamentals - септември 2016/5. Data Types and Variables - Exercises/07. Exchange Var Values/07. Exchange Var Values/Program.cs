using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesWork
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5;
            int num2 = 10;

            Console.WriteLine("Before:");
            Console.WriteLine("a = " + num1);
            Console.WriteLine("b = " + num2);
            Console.WriteLine("After:");
            Console.WriteLine("a = " + num1 * 2);
            Console.WriteLine("b = " + num2 / 2);
        }
    }
}
