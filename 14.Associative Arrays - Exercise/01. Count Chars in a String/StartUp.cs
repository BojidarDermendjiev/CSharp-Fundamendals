namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            SortedDictionary<char, int> counts;
            string inputLine;
            GetInfo(out counts, out inputLine);
            Engine(counts, inputLine);
            IO(counts);
        }
        private static void GetInfo(out SortedDictionary<char, int> counts, out string inputLine)
        {
            counts = new SortedDictionary<char, int>();
            inputLine = Console.ReadLine();
        }
        private static void Engine(SortedDictionary<char, int> counts, string inputLine)
        {
            foreach (var letter in inputLine)
            {
                if (letter == ' ')
                    continue;
                if (counts.ContainsKey(letter))
                    counts[letter]++;
                else
                    counts.Add(letter, 1);
            }
        }
        private static void IO(SortedDictionary<char, int> counts)
        {
            foreach (var letter in counts)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
