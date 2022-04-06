using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
                    var oddChars = password.Where((x, i) => i % 2 != 0).ToArray();

                    password = string.Join("", oddChars);

                    //StringBuilder result = new StringBuilder();
                    //foreach (var item in oddChars)
                    //{
                    //    result.Append(item);
                    //}
                    //password = result.ToString();
                    Console.WriteLine(password);
                }
                else if (cmdType == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);
                    password = password.Remove(index, length);
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
