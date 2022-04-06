using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3._1_Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                var cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);

                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (cmdType == "Reverse")
                {
                    string substring = cmdArgs[1];

                    if (!message.Contains(substring))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        int stratIndex = message.IndexOf(substring);
                        message = message.Remove(stratIndex,substring.Length);
                        message = message + string.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    message = message.Replace(substring, replacement);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message.ToString()}");
        }
    }
}
