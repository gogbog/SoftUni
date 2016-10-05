using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}. You are {2} years old", firstName, secondName, age);


        }
    }
}
