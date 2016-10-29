using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _03_Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            Dictionary<string, long> teams = new Dictionary<string, long>();
            Dictionary<string, long> teamGoals = new Dictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("final"))
                {
                    break;
                }

                input = input.Replace(key, "--");
                string rgx = ".*?--(.+?)--.*--(.+?)--.*\\s(.+)";

                Regex regex = new Regex(rgx);

                MatchCollection collection = regex.Matches(input);

                foreach (Match match in collection)
                {
                    var firstTeam = new string(match.Groups[1].Value.ToArray().Reverse().ToArray()).ToUpper();
                    var secondTeam = new string(match.Groups[2].Value.ToArray().Reverse().ToArray()).ToUpper();
                    var result = new string(match.Groups[3].Value.ToArray().ToArray()).Trim().Split(':').Select(int.Parse).ToArray();

                    int firstTeamScore = result[0];
                    int seconTeamScore = result[1];


                    if (!teams.ContainsKey(firstTeam))
                    {
                        teams.Add(firstTeam, 0);
                        teamGoals.Add(firstTeam, 0);
                    }

                    if (!teams.ContainsKey(secondTeam))
                    {
                        teams.Add(secondTeam, 0);
                        teamGoals.Add(secondTeam, 0);
                    }

                    teamGoals[firstTeam] += firstTeamScore;
                    teamGoals[secondTeam] += seconTeamScore;

                    if (firstTeamScore > seconTeamScore)
                    {
                        teams[firstTeam] += 3;
                    }

                    if (firstTeamScore < seconTeamScore)
                    {
                        teams[secondTeam] += 3;
                    }

                    if (firstTeamScore == seconTeamScore)
                    {
                        teams[firstTeam] += 1;
                        teams[secondTeam] += 1;
                    }

                }

            }

            var teamlist = teams.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            var teamListGoals = teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3).ToList();
            int count = 1;

            Console.WriteLine("League standings:");

            foreach (var team in teamlist)
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var teamGoal in teamListGoals)
            {
                Console.WriteLine($"- {teamGoal.Key} -> {teamGoal.Value}");
            }


        }
    }
}
