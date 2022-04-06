using System;

namespace _2._1_World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stops = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Travel")
            {
                var cmdArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string text = cmdArgs[2];
                    if (IsIndicesValid(index, stops))
                    {
                        stops = stops.Insert(index, text);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (IsIndicesValid(startIndex, stops) && IsIndicesValid(endIndex, stops))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(stops);

                }
                else if (cmdType == "Switch")
                {
                    string oldText = cmdArgs[1];
                    string newText = cmdArgs[2];

                    stops = stops.Replace(oldText, newText);
                    Console.WriteLine(stops);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

        }

        static bool IsIndicesValid(int index, string str)
        {
            return index >= 0 && index < str.Length;
        }
    }
}
