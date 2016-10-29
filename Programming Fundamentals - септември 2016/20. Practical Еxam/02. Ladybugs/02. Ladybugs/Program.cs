using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            //by the same fly length. If the ladybug flies out of the field, it is gone.
            short bugsCount = short.Parse(Console.ReadLine());
            int[] bugs = new int[bugsCount];
            int[] bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //initiate the bugs array
            for (int i = 0; i < bugIndexes.Length; i++)
            {
                if (bugIndexes[i] >= bugs.Length || bugIndexes[i] < 0)
                {
                    continue;
                }

                bugs[bugIndexes[i]] = 1;
            }

            while (true)
            {
                string commandInfo = Console.ReadLine();

                if (commandInfo.Equals("end"))
                    break;

                string[] command = commandInfo.Split();
                short index = short.Parse(command[0]);
                string side = command[1];
                short moveTimes = short.Parse(command[2]);

                //dali sushtestvuva
                if (index >= bugsCount - 1 || index < 0)
                    continue;

                //dali nqma bug vutre
                if (bugs[index] == 0)
                {
                    continue;
                }


                if (side == "right")
                {
                    while (true)
                    {
                        
                        if (index + moveTimes >= bugsCount - 1)
                        {
                            bugs[index] = 0;
                            break;
                        }

                        if (bugs[index + moveTimes] == 0)
                        {
                            bugs[index] = 0;
                            bugs[index + moveTimes] = 1;
                            break;
                        }

                        if (moveTimes == 0)
                        {
                            break;
                        }
                            moveTimes += moveTimes;
                        
                    }

                }
                else
                {
                    while (true)
                    {
                        if (index - moveTimes < 0)
                        {
                            bugs[index] = 0;
                            break;
                        }

                        if (bugs[index - moveTimes] == 0)
                        {
                            bugs[index] = 0;
                            bugs[index - moveTimes] = 1;
                            break;
                        }

                        if (moveTimes == 0)
                        {
                            break;
                        }

                        moveTimes += moveTimes;
                        
                    }
                }
                

            }

            Console.WriteLine(string.Join(" ", bugs));


        }
    }
}
