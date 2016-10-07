using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                int value = int.Parse(Console.ReadLine());

                if (data.ContainsKey(command))
                {
                    data[command] += value;
                }
                else
                {
                    data.Add(command, value);
                }
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
