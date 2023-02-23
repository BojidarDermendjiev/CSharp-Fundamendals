namespace _05._Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var teams = new List<Team>();
            CreatTeam(teams);
            FillTeams(teams);
            IO(teams);
        }
        private static void CreatTeam(List<Team> teams)
        {
           var countOfTeamToBeCreated = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfTeamToBeCreated; i++)
            {
                var tokens = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (teams.Any(x => x.Name == tokens[1]))
                    Console.WriteLine($"Team {tokens[1]} was already created!");
                else if (teams.Any(x => x.TeamLeader == tokens[0]))
                    Console.WriteLine($"{tokens[0]} cannot create another team!");
                else
                {
                    teams.Add(new Team(tokens[1], tokens[0], new List<string>()));
                    Console.WriteLine($"Team {tokens[1]} has been created by {tokens[0]}!");
                }

            }
        }
        private static void FillTeams(List<Team> teams)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "end of assignment")
            {
                var tokens = inputLine.Split("->");
                if (teams.Any(x => x.Members.Contains(tokens[0])) || teams.Any(x => x.TeamLeader == tokens[0]))
                    Console.WriteLine($"Member {tokens[0]} cannot join team {tokens[1]}!");
                else if (teams.All(x => x.Name != tokens[1]))
                    Console.WriteLine($"Team {tokens[1]} does not exist!");
                else
                { 
                 Team currentTeam = teams.Find(x => x.Name == tokens[1]);
                    currentTeam.Members.Add(tokens[0]);
                }
            }

        }
        private static void IO(List<Team> teams)
        {
            var completedTeams = teams.Where(x => x.Members.Count > 0).ToList();
            var disbanedTeams = teams.Where(x => x.Members.Count == 0).ToList();
            foreach (var team in completedTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.TeamLeader}");
                foreach (var user in team.Members.OrderBy(x => x))
                    Console.WriteLine($"-- {user}");
            }
            Console.WriteLine($"Teams to disband:");
            if (disbanedTeams != null)
                foreach (var team in disbanedTeams.OrderBy(x => x.Name))
                    Console.WriteLine($"{team.Name}");
        }
    }
    public class Team
    {
        public Team(string user, string teamLeader, List<string> users)
        {
            Name = user;
            TeamLeader = teamLeader;
            Members = users;
        }
        public string Name { get; set; }
        public string TeamLeader { get; set; }
        public List<string> Members { get; set; }
    }
}
