using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, char[]> map = new Dictionary<int, char[]>();

            int[] startingPoint = new int[2];
            int[] exitPoint = new int[2];

            for (int i = 0; i < n; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();

                for (int z = 0; z < line.Length; z++)
                {
                    if (line[z] == 'S')
                    {
                        startingPoint[0] = i; // tova e key-a na Dictonaryto (reda)
                        startingPoint[1] = z; // tova e mqstoto na koeto se namira
                    }

                    if (line[z] == 'E')
                    {
                        exitPoint[0] = i; // tova e key-a na Dictonaryto
                        exitPoint[1] = z; // tova e mqstoto na koeto se namira
                    }
                }

                map.Add(i, line);
            }


            char[] orders = Console.ReadLine().ToCharArray();

            
            
            foreach (char order in orders)
            {
                if (order == 'D')
                {
                    if (startingPoint[1] > map[startingPoint[0] + 1].Length)
                    {
                        //go to next
                    }
                    else
                    {
                        map[startingPoint[0] + 1][startingPoint[1]] = 'S';
                        startingPoint
                    }
                }

                if (order == 'U')
                {

                }

                if (order == 'L')
                {

                }

                if (order == 'D')
                {

                }
            }
            
            

            
        }
    }
}
