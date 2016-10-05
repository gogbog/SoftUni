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

            var number = Console.ReadLine();

            var decValue = Convert.ToInt32(number, 16);

            Console.WriteLine(decValue);

        }
    }
}