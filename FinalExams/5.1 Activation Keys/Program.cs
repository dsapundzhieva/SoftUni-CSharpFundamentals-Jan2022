using System;
using System.Text;

namespace _5._1_Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Generate")
            {
                var cmdArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];


                if (cmdType == "Contains")
                {
                    string substring = cmdArgs[1];

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmdType == "Flip")
                {
                    string flipType = cmdArgs[1];
                    int startIdx = int.Parse(cmdArgs[2]);
                    int endIdx = int.Parse(cmdArgs[3]);

                    if (flipType == "Upper")
                    {
                        string substring = activationKey.Substring(startIdx, endIdx - startIdx);
                        activationKey = activationKey.Replace(substring, substring.ToUpper());
                        Console.WriteLine(activationKey);
                    }
                    else if (flipType == "Lower")
                    {
                        string substring = activationKey.Substring(startIdx, endIdx - startIdx);
                        activationKey = activationKey.Replace(substring, substring.ToLower());
                        Console.WriteLine(activationKey);
                    }

                }
                else if (cmdType == "Slice")
                {
                    int startIdx = int.Parse(cmdArgs[1]);
                    int endIdx = int.Parse(cmdArgs[2]);

                    string substring = activationKey.Substring(startIdx, endIdx - startIdx);
                    activationKey = activationKey.Replace(substring, "");
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
