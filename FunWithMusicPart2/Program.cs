using System;
namespace Songs_Music
{
    class Program
    {
        enum Genre
        {
            Jazz,
            Rock,
            Swing,
            Orchestral,
            Country
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength:" + Length + "\nGenre:" + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite Song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who wrote it?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What album is it from?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What kind of music is it? i.e genre.");
            Console.WriteLine("J - Jazz\nR - Rock\nS - Swing\nO - Orchestral\nC - Country");
            Genre tempGenre = Genre.Jazz;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'S':
                    tempGenre = Genre.Swing;
                    break;
                case 'O':
                    tempGenre = Genre.Orchestral;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
            }
            Music song = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music moreMusic = song;

            Console.WriteLine("What is the next song on the album?");
            string newTitle = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            string newLength = Console.ReadLine();

            moreMusic.setTitle(newTitle);
            moreMusic.setLength(newLength);
            Console.WriteLine("This is the first song:");
            Console.WriteLine($"{song.Display()}");
            Console.WriteLine("This is the second song:");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}