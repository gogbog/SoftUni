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
            var data = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    data.Add(name, email);
                }

                
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
