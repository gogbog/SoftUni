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

            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            decimal id = decimal.Parse(Console.ReadLine());
            long employeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + secondName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + employeeNumber);

        }
    }
}