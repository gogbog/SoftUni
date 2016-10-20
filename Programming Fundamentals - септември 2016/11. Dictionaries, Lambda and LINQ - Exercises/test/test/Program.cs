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

            List<string> test = myMethod();


            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

        }

        static List<string> myMethod()
        {
            List<string> addingtoList = new List<string>();
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                addingtoList.Add(input);
                input = Console.ReadLine();
            }

            return addingtoList;
        }
    }


}