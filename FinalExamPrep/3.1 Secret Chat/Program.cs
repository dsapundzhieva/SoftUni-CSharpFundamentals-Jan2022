using System;
using System.Linq;

namespace _3._1_Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;

            while((command = Console.ReadLine()) != "Reveal")
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
                    string subtsring = cmdArgs[1];

                    if (message.Contains(subtsring))
                    {
                        int startIndex = message.IndexOf(subtsring);
                        message = message.Remove(startIndex, subtsring.Length);
                        message = message + string.Join("", subtsring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
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
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
