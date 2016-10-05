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
            string name = Console.ReadLine();
            SayHello(name);
        }

        private static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
