using System;

namespace _2._1_World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Travel")
            {
                var cmdArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                var cmdType = cmdArgs[0];

                if (cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string text = cmdArgs[2];

                    if (isIndexValid(stops, index))
                    {
                        stops = stops.Insert(index, text);
                    }
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (isIndexValid(stops, startIndex) && isIndexValid(stops, endIndex))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex+1);
                    }
                }
                else if (cmdType == "Switch")
                {
                    string oldText = cmdArgs[1];
                    string newText = cmdArgs[2];

                    if (stops.Contains(oldText))
                    {
                        stops = stops.Replace(oldText, newText);
                    }
                }
                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }


        static bool isIndexValid(string text, int index)
        {
            return index >= 0 && index < text.Length;
        }
    }
}
