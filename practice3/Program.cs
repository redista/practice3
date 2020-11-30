using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<Song> Playlist = new List<Song>();

            Song song1 = new Song("The Lourve", "Lorde", 4.31, Genre.Pop);
            Song song2 = new Song("Rocket Man", "Elton John", 4.41, Genre.Pop);
            Song song3 = new Song("This Charming Man", "The Smiths", 2.42, Genre.Other);
            Song song4 = new Song("Tiny Dancer", "Elton John", 6.17, Genre.Pop);
            Song song5 = new Song("Run Away With Me", "Carly Rae Jepsen", 4.11, Genre.Dance);

            Playlist.Add(song1);
            Playlist.Add(song2);
            Playlist.Add(song3);
            Playlist.Add(song4);
            Playlist.Add(song5);

            DisplayPlaylist(Playlist);

            Console.WriteLine("\nSorting playlist\n");

            Playlist.Sort();

            DisplayPlaylist(Playlist);

            Console.WriteLine("\nShuffling playlist\n");

            ShufflePlaylist(Playlist);

            DisplayPlaylist(Playlist);

            Console.ReadLine();
        }

        static void DisplayPlaylist(List<Song> playlist)
        { 
            Console.WriteLine("{0,-25}{1,-25}{2,-10}{3,-10}", "Title", "Artist", "Duration", "Genre");
            foreach (Song song in playlist)
                Console.WriteLine(song);
        }

        static void ShufflePlaylist(List<Song> playlist)
        {
            // Uses Fisher-Yates shuffle
            
            Random rnd = new Random();

            int numOfSongs = playlist.Count - 1;

            while (numOfSongs > 0)
            {
                int rndIndex = rnd.Next(0, numOfSongs + 1);
                Song temp = playlist[numOfSongs];
                playlist[numOfSongs] = playlist[rndIndex];
                playlist[rndIndex] = temp;

                numOfSongs--;
            }
        }
    }
}
