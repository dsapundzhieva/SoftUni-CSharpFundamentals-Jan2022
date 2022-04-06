using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3_The_Pianist
{
    class Pianist
    {
        public Pianist(string piece, string compser, string key)
        {
            this.Piece = piece;
            this.Composer = compser;
            this.Key = key;
        }
        public string Piece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Pianist> list = new List<Pianist>();

            for (int i = 0; i < n; i++)
            {
                var pieces = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];

                Pianist pianist = new Pianist(piece, composer, key);
                list.Add(pianist);
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
                    list = AddGivenPiecesToTheList(list, piece, composer, key);
                }
                else if (cmdType == "Remove")
                {
                    string piece = cmdArgs[1];
                    list = RemovePiece(list, piece);
                }
                else if (cmdType == "ChangeKey")
                {
                    string piece = cmdArgs[1];
                    string newKey = cmdArgs[2];

                    list = ChangeKeyWithTheGivenOne(list, piece, newKey);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Piece} -> Composer: {item.Composer}, Key: {item.Key}");
            }
        }

        static List<Pianist> ChangeKeyWithTheGivenOne(List<Pianist> list, string piece, string newKey)
        {
            var matches = list.Where(p => p.Piece == piece);

            if (matches.Any())
            {
                Pianist pianist = list.Find(p => p.Piece == piece);
                pianist.Key = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
                return list;
        }
        static List<Pianist> RemovePiece(List<Pianist> list, string piece)
        {
            var matches = list.Where(p => p.Piece == piece);
            if (matches.Any())
            {
                Pianist pianist = list.Find(p => p.Piece == piece);
                list.Remove(pianist);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
            return list;
        }
        static List<Pianist> AddGivenPiecesToTheList(List<Pianist> list, string piece, string composer, string key)
        {
            var matches = list.Where(p => p.Piece == piece);
            if (matches.Any())
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            else
            {
                list.Add(new Pianist(piece, composer, key));
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
            }

            return list;
        }
    }
}
