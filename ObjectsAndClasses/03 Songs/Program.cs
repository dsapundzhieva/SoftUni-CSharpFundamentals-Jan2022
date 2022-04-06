using System;
using System.Collections.Generic;

namespace _03_Songs
{
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] commandParams = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);

                string typeList = commandParams[0];
                string name = commandParams[1];
                string time = commandParams[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string typeListToSearch = Console.ReadLine();

            if (typeListToSearch == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredList = songs
                    .FindAll(song => song.TypeList == typeListToSearch);

                foreach (Song song in filteredList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
