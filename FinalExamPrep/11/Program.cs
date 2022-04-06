using System;

namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while((command = Console.ReadLine()) != "Done")
            {
                var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Change")
                {
                    string ch = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    input = input.Replace(ch, replacement);

                    Console.WriteLine(input);
                }
                else if (cmdType == "Includes")
                {
                    string substring = cmdArgs[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmdType == "End")
                {
                    string substring = cmdArgs[1];

                    string endSubstring = input.Substring(input.Length - substring.Length);

                    if (endSubstring == substring)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmdType == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (cmdType == "FindIndex")
                {
                    string ch = cmdArgs[1];
                    int indexOfFirstChar = input.IndexOf(ch);
                    Console.WriteLine(indexOfFirstChar);
                }
                else if (cmdType == "Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);
                    string substring = input.Substring(startIndex, count);
                    input = substring;

                    Console.WriteLine(input);
                }
            }
        }
    }
}
