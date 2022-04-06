using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_TeamworkProjects
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            this.Name = teamName;
            this.Creator = creatorName;

            this.Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] projectParams = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creatorName = projectParams[0];
                string teamName = projectParams[1];


                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(user => user.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string command;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinParams = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string memberName = joinParams[0];
                string teamName = joinParams[1];

                Team searchedTeamToJoin = teams.FirstOrDefault(team => team.Name == teamName);

                if (searchedTeamToJoin == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(team => team.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }            
                if (teams.Any(team => team.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                searchedTeamToJoin.AddMember(memberName);
            }

            List<Team> teamsWithMembers = teams
                .Where(team => team.Members.Count > 0)
                .OrderByDescending(team => team.Members.Count)
                .ThenBy(team => team.Name)
                .ToList();

            List<Team> teamToDisband = teams
                .Where(team => team.Members.Count == 0)
                .OrderBy(team => team.Name)
                .ToList();

            PrintValidTeams(teamsWithMembers);
            PrintInvalidTeams(teamToDisband);
        }

        static void PrintInvalidTeams(List<Team> invalidTeams)
        {
            Console.WriteLine("Teams to disband: ");
            foreach (Team invalidTeam in invalidTeams)
            {
                Console.WriteLine($"{invalidTeam.Name}");
            }
        }

        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.Name}");
                Console.WriteLine($"- {validTeam.Creator}");

                foreach (string currMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currMember}");
                }
            }
        }

      
        static bool IsTheTeamExist(List<Team> teamProjects, string teamToJoin)
        {
            foreach (Team team in teamProjects)
            {
                if (team.Name.Contains(teamToJoin))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
