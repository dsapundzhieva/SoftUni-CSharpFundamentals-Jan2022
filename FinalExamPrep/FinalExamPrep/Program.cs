using System;

namespace FinalExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                var cmdArgs = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Move")
                {
                    int n = int.Parse(cmdArgs[1]);
                    message = MoveLetterAtTheEnd(message, n);
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    message = InsertGivenValueBeforeTheGivenIndex(message, index, value);
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    message = ChangeAllOccurrences(message, substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }

        static string ChangeAllOccurrences(string message, string substring, string replacement)
        {
            message = message.Replace(substring, replacement);
            return message;
        }
        static string InsertGivenValueBeforeTheGivenIndex(string message, int index, string value)
        {
            message = message.Insert(index, value);

            return message;
        }

        static string MoveLetterAtTheEnd(string message, int n)
        {
            string substring = message.Substring(0, n);
            message = message.Remove(0, n);
            message = message + substring;

            return message;
        }
    }
}
