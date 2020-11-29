using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }

    class Song : IComparable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre SongGenre { get; set; }

        public Song(string title, string artist, double duration, Genre genre)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
            this.SongGenre = genre;
        }

        public Song(string title, string artist) : this(title, artist, 0, Genre.Other)
        { }

        public Song() : this("Unknown", "Unkown")
        { }

        public override string ToString()
        {
            return String.Format($"{Title, -25}{Artist, -25}{Duration, -10}{SongGenre, -10}");
        }

        public int CompareTo(object obj)
        {
            Song other = obj as Song;

            int val = this.Artist.CompareTo(other.Artist);

            if (val == 0)
                return this.Title.CompareTo(other.Title);
            else
                return val;
        }
    }
}
