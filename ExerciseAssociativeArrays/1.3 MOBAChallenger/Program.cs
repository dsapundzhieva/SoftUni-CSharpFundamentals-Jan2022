using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3_MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, Dictionary<string, int>> playerList = new Dictionary<string, Dictionary<string, int>>();

            while ((command = Console.ReadLine()) != "Season end")
            {
                var cmdSplit = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdSplit[1].Equals("vs"))
                {
                    var cmdArgs = command.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    string firstPlayer = cmdArgs[0];
                    string secondPlayer = cmdArgs[1];

                    if (playerList.ContainsKey(firstPlayer) && playerList.ContainsKey(secondPlayer))
                    {
                        var isPositionContains = playerList[secondPlayer].Any(x => playerList[firstPlayer].ContainsKey(x.Key));

                        if (isPositionContains)
                        {
                            var firstPlayerSum = playerList[firstPlayer].Select(x => x.Value).Sum();
                            var secondPlayerSum = playerList[secondPlayer].Select(x => x.Value).Sum();
                            playerList.Remove(firstPlayerSum < secondPlayerSum ? firstPlayer : secondPlayer);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    var cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string playerName = cmdArgs[0];
                    string position = cmdArgs[1];
                    int skill = int.Parse(cmdArgs[2]);

                    if (!playerList.ContainsKey(playerName))
                    {
                        playerList[playerName] = new Dictionary<string, int>();
                        playerList[playerName].Add(position, skill);
                        //playerList[playerName][position] = skill;
                    }
                    else
                    {
                        if (!playerList[playerName].ContainsKey(position))
                        {
                            playerList[playerName].Add(position, skill);
                        }
                        else
                        {
                            if (playerList[playerName][position] < skill)
                            {
                                playerList[playerName][position] = skill;
                            }
                        }
                    }
                }
            }

            

            foreach (var item in playerList.OrderByDescending(x => x.Value.Select(x => x.Value).Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Select(x => x.Value).Sum()} skill");

                foreach (var position in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {string.Join("- ", position.Key)} <::> {position.Value}");
                }
            }
        }
    }
}
