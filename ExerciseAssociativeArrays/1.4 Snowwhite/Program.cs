using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._4_Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfList = new Dictionary<string, Dictionary<string, int>>();
            string command;

            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                var cmdArgs = command.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = cmdArgs[0];
                string dwarfColor = cmdArgs[1];
                int dwarfPhisics = int.Parse(cmdArgs[2]);

                if (!dwarfList.ContainsKey(dwarfColor))
                {
                    dwarfList.Add(dwarfColor, new Dictionary<string, int>());
                    dwarfList[dwarfColor][dwarfName] = dwarfPhisics;
                }
                else if (!dwarfList[dwarfColor].ContainsKey(dwarfName))
                {
                    dwarfList[dwarfColor][dwarfName] = dwarfPhisics;
                }
                if (dwarfList[dwarfColor][dwarfName] < dwarfPhisics)
                {
                    dwarfList[dwarfColor][dwarfName] = dwarfPhisics;
                }
            }

            foreach (var item in dwarfList.OrderByDescending(x => dwarfList.Values).ThenByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in item.Value)
                {
                    Console.WriteLine($"({item.Key}) {dwarf.Key} <-> {dwarf.Value}");
                }
            }
        }

        //Dictionary<string, List<Dictionary<string, int>>> dwarfList = new Dictionary<string, List<Dictionary<string, int>>>();
        //string command;

        //while ((command = Console.ReadLine()) != "Once upon a time")
        //{
        //    var cmdArgs = command.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

        //    string dwarfName = cmdArgs[0];
        //    string dwarfColor = cmdArgs[1];
        //    int dwarfPhisics = int.Parse(cmdArgs[2]);

        //    if (!dwarfList.ContainsKey(dwarfName))
        //    {
        //        Dictionary<string, int> dwarfColorAndPhisics = new Dictionary<string, int>();
        //        dwarfColorAndPhisics.Add(dwarfColor, dwarfPhisics);

        //        List<Dictionary<string, int>> dictList = new List<Dictionary<string, int>>();
        //        dictList.Add(dwarfColorAndPhisics);

        //        dwarfList.Add(dwarfName, dictList);

        //    }
        //    else
        //    {
        //        if (dwarfList[dwarfName].Any(x => x.ContainsKey(dwarfColor)))
        //        {
        //            dwarfList[dwarfName].Select(x =>  
        //        {
        //            if (x[dwarfColor] < dwarfPhisics)
        //            {
        //                x[dwarfColor] = dwarfPhisics;
        //            }
        //            return x;
        //        });

        //        }
        //        else
        //        {
        //            Dictionary<string, int> dictList = new Dictionary<string, int>();
        //            dictList.Add(dwarfColor, dwarfPhisics);
        //            dwarfList[dwarfName].Add(dictList);
        //        }
        //    }
        //}

    }
}
