using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.shit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Event> events = new List<Event>();



            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine.Equals("Time for Code"))
                {
                    break;
                }

                string[] eventInfo = inputLine.Split();

                Event subitie = new Event();

                subitie.id = long.Parse(eventInfo[0]);
                subitie.name = eventInfo[1].Substring(1);

                if (eventInfo[1].ToCharArray().First() != '#')
                {
                    continue;
                }

                if (events.Any(x => x.id == long.Parse(eventInfo[0]) && x.name != subitie.name))
                {
                    continue;
                }

                if (events.Any(x => x.id == long.Parse(eventInfo[0]) && x.name == eventInfo[1].Substring(1)))
                {
                    subitie = events.FirstOrDefault(e => e.id == long.Parse(eventInfo[0]) && e.name == eventInfo[1].Substring(1));
                }
                else
                {
                    subitie.crewMembers = new List<string>();
                }

                for (long i = 2; i < eventInfo.Length; i++)
                {
                    string member = eventInfo[i];

                    if (member.ToCharArray().First() != '@')
                    {
                        continue;
                    }

                    if (!subitie.crewMembers.Contains(member))
                    {
                        subitie.crewMembers.Add(member);
                    }
                }

                if (!events.Any(x => x.id == long.Parse(eventInfo[0])))
                {
                    events.Add(subitie);
                }
                

                

                
            }


            foreach (var subitie in events.OrderByDescending(x => x.crewMembers.Count).ThenBy(x => x.name))
            {
                Console.WriteLine($"{subitie.name} - {subitie.crewMembers.Count}");

                foreach (var member in subitie.crewMembers.OrderBy(x => x))
                {
                    Console.WriteLine(member);
                }
            }

        }
    }

    class Event
    {
        public long id { get; set; }
        public string name { get; set; }
        public List<string> crewMembers;
    }
}
