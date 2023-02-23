namespace _01._Advertisement_Message
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            Advertisement message;
            int countOfMessages;
            GetInfo(out message, out countOfMessages);
            Random rnd = new Random();
            IO(message, countOfMessages, rnd);
        }
        private static void GetInfo(out Advertisement message, out int countOfMessages)
        {
            message = new Advertisement(new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." }, new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" }, new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" }, new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" });
            countOfMessages = int.Parse(Console.ReadLine());
        }
        private static void IO(Advertisement message, int countOfMessages, Random rnd)
        {
            for (int i = 0; i < countOfMessages; i++)
            {
                var phares = rnd.Next(0, message.Phrases.Count);
                var events = rnd.Next(0, message.Events.Count);
                var authors = rnd.Next(0, message.Authors.Count);
                var cities = rnd.Next(0, message.Cities.Count);
                Console.WriteLine($"{message.Phrases[phares]} {message.Events[events]} {message.Authors[authors]} - {message.Cities[cities]}.");
            }
        }
    }
    public class Advertisement
    {
        public Advertisement(List<string> phrases, List<string> events, List<string> authors, List<string> cities)
        {
            Phrases = phrases;
            Events = events;
            Authors = authors;
            Cities = cities;
        }
        public List<string> Phrases { get; set; }
        public List<string> Events { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Cities { get; set; }
    }
}
