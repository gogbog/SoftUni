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
            Dictionary<string, int> myDict = new Dictionary<string, int>();

            string resource = "";
            int quantity = 0;

            for (int i = 1; ; i++)
            {
                if (i % 2 != 0)
                {
                    resource = Console.ReadLine();

                }
                if (i % 2 == 0)
                {
                    quantity = int.Parse(Console.ReadLine());
                }
                if (resource.Equals("stop"))
                {
                    break;
                }
                

                if (!myDict.ContainsKey(resource))
                {
                    myDict.Add(resource, 0);
                }

                myDict[resource] += quantity;
            }

            foreach (var item in myDict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}