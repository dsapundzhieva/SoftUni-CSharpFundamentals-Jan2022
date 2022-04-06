using System;
using System.Linq;

namespace _4._1_Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "TakeOdd")
                {
                    var oddLetters = password.Where((o, i) => i % 2 != 0).ToArray();
                    password = string.Join("", oddLetters);
                    Console.WriteLine(password);
                }
                else if (cmdType == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    string substring = password.Substring(index, length);
                    int startIndxToRemove = password.IndexOf(substring);
                    password = password.Remove(startIndxToRemove, length);
                    Console.WriteLine(password);
                }
                else if (cmdType == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
