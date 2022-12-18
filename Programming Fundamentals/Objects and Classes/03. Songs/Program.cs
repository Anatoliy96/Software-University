using System;
using System.Collections.Generic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split("_");
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song();

                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string favoriteOrAll = Console.ReadLine();

            if (favoriteOrAll == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == favoriteOrAll)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
