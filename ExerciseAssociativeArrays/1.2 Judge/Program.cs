using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._2_Judge
{
    //class User
    //{
    //    public User(string name, int points)
    //    {
    //        this.UserNameInfo = new List<Tuple<string, int>>();
    //        this.Name = name;
    //        this.Points = points;
    //    }

    //    public string Name { get; set; }

    //    public int Points { get; set; }
    //    public List<Tuple<string, int>> UserNameInfo { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, List<Tuple<string, int>>> judgeList = new Dictionary<string, List<Tuple<string, int>>>();
            Dictionary<string, int> individualStatistics = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "no more time")
            {
                var cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string userName = cmdArgs[0];
                string contest = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);

                if (!judgeList.ContainsKey(contest))
                {
                    judgeList[contest] = new List<Tuple<string, int>>();
                    judgeList[contest].Add(new Tuple<string, int>(userName, points));
                }
                else
                {
                    if (judgeList[contest].Any(t => t.Item1.Contains(userName) && t.Item2 < points))
                    {
                        judgeList[contest].RemoveAll(t => t.Item1 == userName && t.Item2 < points);
                        judgeList[contest].Add(new Tuple<string, int>(userName, points));
                        individualStatistics[userName] = points;
                        continue;
                    }
                    else if ((judgeList.ContainsKey(contest) && judgeList[contest].Exists(t => t.Item1 == userName && t.Item2 > points)))
                    {
                        continue;
                    }
                    else if (judgeList.ContainsKey(contest) && judgeList[contest].Any(t => t.Item1 != userName))
                    {
                        judgeList[contest].Add(new Tuple<string, int>(userName, points));
                    }
                }
                if (!individualStatistics.ContainsKey(userName))
                {
                    individualStatistics[userName] = points;
                }
                else
                {
                    individualStatistics[userName] += points;
                }

            }
            
            foreach (var item in judgeList)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()} participants");
                int positionCourse = 1;
                foreach (var participants in item.Value.OrderByDescending(p => p.Item2).ThenBy(n => n.Item1))
                {
                    Console.WriteLine($"{positionCourse}. {participants.Item1} <::> {participants.Item2}");
                    positionCourse++;
                }
            }
            Console.WriteLine("Individual standings: ");
            int position = 1;
            foreach (var item in individualStatistics.OrderByDescending(o => o.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{position}. {item.Key} -> {item.Value}");
                position++;
            }
        }
    }
}
