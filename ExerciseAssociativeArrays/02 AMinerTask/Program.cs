using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, int> collectResources = new Dictionary<string, int>();

            List<string> resourcesString = new List<string>();
            List<int> resourcesInt = new List<int>();

            int count = 0;

            while ((command = Console.ReadLine()) != "stop")
            {
                if (count % 2 == 0)
                {
                    resourcesString.Add(command);
                }
                else
                {
                    resourcesInt.Add(int.Parse(command));
                }
                count++;
            }

            for (int i = 0; i < resourcesString.Count; i++)
            {
                if (collectResources.ContainsKey(resourcesString[i]))
                {
                    collectResources[resourcesString[i]] += resourcesInt[i];
                }
                else
                {
                    collectResources.Add(resourcesString[i], resourcesInt[i]);

                }
            }

            foreach (var item in collectResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
