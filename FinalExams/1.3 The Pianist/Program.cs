using System;
using System.Collections.Generic;

namespace _1._3_The_Pianist
{
    class Piano
    {
        public Piano(string composer, string key)
        {
            this.Composer = composer;
            this.Key = key;
        }
        public string Composer { get; set; }

        public string Key { get; set; }
    }
     class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Piano> pianoList = new Dictionary<string, Piano>();

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = cmdArgs[0];
                string composer = cmdArgs[1];
                string key = cmdArgs[2];

                Piano piano = new Piano(composer, key);

                pianoList.Add(piece, piano);
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                var cmdArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    string piece = cmdArgs[1];
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (!pianoList.ContainsKey(piece))
                    {
                        Piano piano = new Piano(composer, key);
                        pianoList.Add(piece, piano);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (cmdType == "Remove")
                {
                    string piece = cmdArgs[1];

                    if (pianoList.ContainsKey(piece))
                    {
                        pianoList.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (cmdType == "ChangeKey")
                {
                    string piece = cmdArgs[1];
                    string newKey = cmdArgs[2];

                    if (pianoList.ContainsKey(piece))
                    {
                        pianoList[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var item in pianoList)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }
        }
    }
}
