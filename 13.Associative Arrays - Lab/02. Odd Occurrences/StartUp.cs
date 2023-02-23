namespace _02._Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            string[] words;
            Dictionary<string, int> counts;
            GetInfo(out words, out counts);
            Engine(words, counts);
            IO(counts);
        }
        private static void GetInfo(out string[] words, out Dictionary<string, int> counts)
        {
            words = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            counts = new Dictionary<string, int>();
        }
        private static void Engine(string[] words, Dictionary<string, int> counts)
        {
            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (counts.ContainsKey(wordInLowerCase))
                    counts[wordInLowerCase]++;
                else
                    counts.Add(wordInLowerCase, 1);
            }
        }
        private static void IO(Dictionary<string, int> counts)
        {
            foreach (var count in counts)
                if (count.Value % 2 != 0)
                    Console.Write(count.Key + " ");
        }
    }
}
