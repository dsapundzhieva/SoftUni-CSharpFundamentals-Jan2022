using System;
using System.Text;

namespace _1._1_The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                var cmdArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Move")
                {
                    int numberOfLetters = int.Parse(cmdArgs[1]);

                    string substring = encryptedMessage.Substring(0, numberOfLetters);

                    encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);

                    StringBuilder result = new StringBuilder();

                    result.Append(encryptedMessage);
                    result.Append(substring);

                    encryptedMessage = result.ToString();
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
