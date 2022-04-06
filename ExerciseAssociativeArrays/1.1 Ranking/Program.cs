using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._1_Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, string> contestDic = new Dictionary<string, string>();

            Dictionary<string, List<Tuple<string, int>>> submissions = new Dictionary<string, List<Tuple<string, int>>>();


            while ((input = Console.ReadLine()) != "end of contests")
            {
                var cmdArgs = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string contest = cmdArgs[0];
                string password = cmdArgs[1];

                if (!contestDic.ContainsKey(contest))
                {
                    contestDic[contest] = password;
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                var cmdArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                string username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);

                if (contestDic.ContainsKey(contest))
                {
                    if (contestDic.ContainsValue(password))
                    {
                        if (!submissions.ContainsKey(username))
                        {
                            submissions[username] = new List<Tuple<string, int>>();
                        }
                        else
                        {
                            if (submissions.ContainsKey(username) && submissions[username].Any(t => t.Item1.Contains(contest) && t.Item2 < points))
                            {
                                submissions[username].RemoveAll(t => t.Item1 == contest && t.Item2 < points);
                                submissions[username].Add(new Tuple<string, int>(contest, points));
                                continue;
                            }
                            else if (submissions.ContainsKey(username) && submissions[username].Exists(t => t.Item1 == contest && t.Item2 >= points))
                            {
                                continue;
                            }

                        }
                        submissions[username].Add(new Tuple<string, int>(contest, points));
                    }
                }
                else
                {
                    continue;
                }
            }

            Dictionary<string, int> bestCandidates = new Dictionary<string, int>();

            foreach (var item in submissions)
            {
                if (!bestCandidates.ContainsKey(item.Key))
                {
                    bestCandidates[item.Key] = submissions[item.Key].Select(t => t.Item2).Sum();
                }
            }

            string totalPoints = bestCandidates.Max(t => t.Value).ToString();
            string bestCandidate = bestCandidates.FirstOrDefault(t => t.Value == int.Parse(totalPoints)).Key;

           
            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var item in submissions.OrderBy(name => name.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var contest in item.Value.OrderByDescending(t => t.Item2))
                {
                    
                    Console.WriteLine($"#  {contest.Item1} -> {contest.Item2}");
                }
            }
        }
    }
}
