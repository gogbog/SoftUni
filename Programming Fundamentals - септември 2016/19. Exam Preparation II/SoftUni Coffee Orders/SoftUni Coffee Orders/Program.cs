using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < times; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                int[] date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                long capulesCount = long.Parse(Console.ReadLine());
                int monthDays = System.DateTime.DaysInMonth(date[2], date[1]);

                decimal result = (monthDays * capulesCount) * capsulePrice;
                sum += result;

                Console.WriteLine("The price for the coffee is: ${0:F2}", result);
            }

            Console.WriteLine("Total: ${0:F2}", sum);
        }
    }
}
