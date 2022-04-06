using System;
using System.Linq;
using System.Text;

namespace Q03._TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keySequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string command;

            while ((command = Console.ReadLine()) != "find")
            {
                var stringLine = command.ToCharArray();

                
                StringBuilder decryptMessage = new StringBuilder();
                int counter = 0;

                while (counter != stringLine.Length)
                {
                    for (int i = 0; i < keySequence.Length; i++)
                    {
                        if (counter == stringLine.Length)
                        {
                            break;
                        }
                        char currChar = (char)(stringLine[counter] - int.Parse(keySequence[i]));
                        decryptMessage.Append(currChar);
                        counter++;

                    }
                }

                string message = decryptMessage.ToString();
                int startIndexOfType = message.IndexOf('&');
                int endIndexOfType = message.LastIndexOf('&');

                var typeResult = message.Substring(startIndexOfType+1, endIndexOfType - (startIndexOfType +1));

                int startIndexOfCoordinates = message.IndexOf('<');
                int endIndexOfCoordinates = message.LastIndexOf('>');

                var coordinates = message.Substring(startIndexOfCoordinates + 1, endIndexOfCoordinates - (startIndexOfCoordinates + 1));

                Console.WriteLine($"Found {typeResult} at {coordinates}");
            }
        }
    }
}

