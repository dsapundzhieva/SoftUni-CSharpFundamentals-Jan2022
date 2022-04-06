using System;
using System.Collections.Generic;

namespace _08_CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers[companyName] = new List<string>() { employeeId};
                }
                else
                {
                    if (!companyUsers[companyName].Contains(employeeId))
                    {
                        companyUsers[companyName].Add(employeeId);
                    }
                }
            }

            foreach (var item in companyUsers)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value)}");
            }
        }
    }
}
