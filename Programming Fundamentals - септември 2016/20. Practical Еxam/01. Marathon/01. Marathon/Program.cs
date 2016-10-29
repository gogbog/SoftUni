using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long marathonDays = int.Parse(Console.ReadLine());
            long runners = int.Parse(Console.ReadLine());
            long labs = int.Parse(Console.ReadLine());
            long trackLenght = int.Parse(Console.ReadLine());
            long capacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilomter = decimal.Parse(Console.ReadLine());

            long maximumRunners = marathonDays * capacity;

            if (maximumRunners < runners)
            {
                runners = maximumRunners;
            }

            long totalMeters = runners * labs * trackLenght;
            long totalKilomters = totalMeters / 1000;
            Console.WriteLine("Money raised: {0:F2}", totalKilomters * moneyPerKilomter);
        }
    }
}
