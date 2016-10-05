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

            var status = Convert.ToBoolean(number);

            if (status)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}