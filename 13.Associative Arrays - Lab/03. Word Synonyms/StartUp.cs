namespace _03._Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<string>> synomims;
            int number;
            GetInfo(out synomims, out number);
            Engine(synomims, number);
            IO(synomims);
        }
        private static void GetInfo(out Dictionary<string, List<string>> synomims, out int number)
        {
            synomims = new Dictionary<string, List<string>>();
            number = int.Parse(Console.ReadLine());
        }
        private static void Engine(Dictionary<string, List<string>> synomims, int number)
        {
            for (int currentWord = 0; currentWord < number; currentWord++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();
                if (synomims.ContainsKey(word))
                    synomims[word].Add(synonym);
                else
                    synomims.Add(word, new List<string>() { synonym });
            }
        }
        private static void IO(Dictionary<string, List<string>> synomyms)
        {
            foreach (var word in synomyms)
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
        }
    }
}
