namespace _03._Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Song
    {
        public Song(string ratingOfSong, string nameOfSong, string timeOfSong)
        {
            RatingOfSong = ratingOfSong;
            NameOfSong = nameOfSong;
            TimeOfSong = timeOfSong;
        }
        public string RatingOfSong { get; private set; }
        public string NameOfSong { get; private set; }
        public string TimeOfSong { get; private set; }
    }
    public class StartUp
    {
        static void Main()
        {
            int countOfSongs;
            GetInfo(out countOfSongs);
            List<Song> songs = new List<Song>();
            Engine(countOfSongs, songs);
            IO(songs);
        }
        private static void GetInfo(out int countOfSongs)
        {
            countOfSongs = int.Parse(Console.ReadLine());
        }
        private static void Engine(int countOfSongs, List<Song> songs)
        {
            for (int currentSong = 0; currentSong < countOfSongs; currentSong++)
            {
                var inputFromUser = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
                Song song = new Song(inputFromUser[0], inputFromUser[1], inputFromUser[2]);
                songs.Add(song);
            }
        }
        private static void IO( List<Song> songs)
        {
            var getRaringFromUser = Console.ReadLine();
            List<Song> filter = songs.Where(x => x.RatingOfSong == getRaringFromUser).ToList();
            if (getRaringFromUser != "all")
            { 
                PrintSongs(filter);
                return;
            }
            PrintSongs(songs);
        }

        private static void PrintSongs(List<Song> songs)
        {
            foreach (var song in songs)
                Console.WriteLine(song.NameOfSong);
        }
    }
}
