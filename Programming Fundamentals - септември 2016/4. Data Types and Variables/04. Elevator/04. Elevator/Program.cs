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
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int fullCourses = n / p;

            if (n % p != 0)
            {
                fullCourses++;
            }

            Console.WriteLine(fullCourses);

        }
    }
}