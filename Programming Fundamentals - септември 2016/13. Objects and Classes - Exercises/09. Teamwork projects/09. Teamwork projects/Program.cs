using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamCount; i++)
            {
                string[] inputedInfo = Console.ReadLine().Split('-');
                string username = inputedInfo[0];
                string teamName = inputedInfo[1];

                //validation

                if (teams.Any(x => x.name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.creator == username))
                {
                    Console.WriteLine($"{username} cannot create another team!");
                    continue;
                }

                

                //add the team
                Team team = new Team();
                team.name = teamName;
                team.creator = username;
                team.members = new List<string>();
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {username}!");
            }

            string input = Console.ReadLine();

            while (!input.Equals("end of assignment"))
            {
                string[] userTransferInfo = input.Split(new string[] { "->" }, StringSplitOptions.None);
                string username = userTransferInfo[0];
                string joinedTeam = userTransferInfo[1];

                //validation

                if (!teams.Any(x => x.name == joinedTeam))
                {
                    Console.WriteLine($"Team {joinedTeam} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }

                if (teams.Any(x => x.creator == username) || teams.Any(x => x.members.Any(y => y == username)))
                {
                    Console.WriteLine($"Member {username} cannot join team {joinedTeam}!");
                    input = Console.ReadLine();
                    continue;
                }


                //add the member
                Team team = teams.First(x => x.name == joinedTeam);
                team.members.Add(username);
                input = Console.ReadLine();
            }

            List<Team> disbanedTeams = teams.Where(x => x.members.Count == 0).ToList();
            List<Team> allowedTeams = teams.Where(x => x.members.Count != 0).ToList();

            foreach (var teamInfo in allowedTeams.OrderByDescending(x => x.members.Count()).ThenBy(x => x.name))
            {
                Console.WriteLine(teamInfo.name);
                Console.WriteLine($"- {teamInfo.creator}");

                foreach (var member in teamInfo.members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }


                Console.WriteLine("Teams to disband:");
            
            foreach (Team disbannedTeamInfo in disbanedTeams.OrderBy(x => x.name))
            {
                Console.WriteLine(disbannedTeamInfo.name);
            }
        }
    }

    class Team
    {
        public string name { get; set; }
        public string creator { get; set; }
        public List<string> members { get; set; }
    }
}
