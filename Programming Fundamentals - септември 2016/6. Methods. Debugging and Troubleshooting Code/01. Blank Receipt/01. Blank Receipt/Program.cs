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
            Header();
            Body();
            Footer();
        }

        private static void Footer()
        {
            char c = '\u00A9';
            Console.WriteLine("------------------------------");
            System.Console.Write(c.ToString());
            Console.WriteLine(" SoftUni");
        }

        private static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
