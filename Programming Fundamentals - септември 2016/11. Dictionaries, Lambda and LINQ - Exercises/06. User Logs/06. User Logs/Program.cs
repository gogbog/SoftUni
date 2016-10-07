using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInfo = new Dictionary<string, List<string>>();


            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                var ip = input[0].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).Last();
                //var message = input[1].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).Last();
                //message = message.Substring(1, message.Length - 3);
                var user = input[2].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).Last();

                if (!userInfo.ContainsKey(user))
                {
                    userInfo.Add(user, new List<string>());
                }

                userInfo[user].Add(ip);

            }

            var userNames = userInfo.Keys.ToList();
            userNames = userNames.OrderBy(q => q).ToList();

            foreach (var userData in userNames)
            {
                string username = userData;
                var userIPs = new Dictionary<string, int>();

                foreach (var ip in userInfo[username])
                {
                    if (!userIPs.ContainsKey(ip))
                    {
                        userIPs.Add(ip, 1);
                    }
                    else
                    {
                        userIPs[ip]++;
                    }
                }

                Console.WriteLine($"{username}:");
                int count = 0;
                foreach (var ipData in userIPs)
                {
                    Console.Write($"{ipData.Key} => {ipData.Value}");

                    if (count != userIPs.Count - 1)
                    {
                        Console.Write(", ");
                    }
                    count++;
                }
                Console.WriteLine('.');
            }
           
        }
    }
}
