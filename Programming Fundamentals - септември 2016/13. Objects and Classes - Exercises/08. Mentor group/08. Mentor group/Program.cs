using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_group
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            string inputedInfo = Console.ReadLine();

            while (!inputedInfo.Equals("end of dates"))
            {
                string[] userDateInfo = inputedInfo.Split();
                string username = userDateInfo[0];
                User user;

                if (!users.Any(x => x.username == username))
                {
                    user = new User();
                    user.username = username;
                    user.dates = new List<DateTime>();
                    user.comments = new List<string>();
                }
                else
                {
                     user = users.First(x => x.username == username);
                }
                

                if (userDateInfo.Length > 1)
                {
                    string[] userDates = userDateInfo[1].Split(',');

                    for (int i = 0; i < userDates.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(userDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        user.dates.Add(date);
                    }
                }

                if (!users.Any(x => x.username == username))
                {
                    users.Add(user);
                }

                inputedInfo = Console.ReadLine();
            }

            inputedInfo = Console.ReadLine();

            while (!inputedInfo.Equals("end of comments"))
            {
                string[] userCommentsInfo = inputedInfo.Split('-');
                string username = userCommentsInfo[0];
                string comment = userCommentsInfo[1];

                if (!users.Any(x => x.username == username))
                {
                    inputedInfo = Console.ReadLine();
                    continue;
                }

                User user = users.First(x => x.username == username);
                user.comments.Add(comment);

                inputedInfo = Console.ReadLine();
            }

            foreach (User user in users.OrderBy(x => x.username))
            {
                Console.WriteLine(user.username);
                Console.WriteLine("Comments:");
                if (user.comments.Count != 0)
                {
                    foreach (string comment in user.comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                if (user.dates.Count != 0)
                {
                    foreach (var date in user.dates.OrderBy(x => x))
                    {
                        Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                    }
                }
            }
        }
    }

    class User
    {
        public string username { get; set; }
        public List<DateTime> dates { get; set; }
        public List<string> comments { get; set; }
    }
    
}
