namespace _04._Star_Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        static void Main()
        {
            string pattern;
            int lineOfInput;
            List<string> attacked, destroyed;
            GetInfo(out pattern, out lineOfInput, out attacked, out destroyed);
            Engine(pattern, lineOfInput, attacked, destroyed);
            IO(attacked, destroyed);
        }

        private static void GetInfo(out string pattern, out int lineOfInput, out List<string> attacked, out List<string> destroyed)
        {
            pattern = @"@(?<nameOfPlanet>[A-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<count>[\d]+)";
            lineOfInput = int.Parse(Console.ReadLine());
            attacked = new List<string>();
            destroyed = new List<string>();
        }

        private static void Engine(string pattern, int lineOfInput, List<string> attacked, List<string> destroyed)
        {
            for (int i = 0; i < lineOfInput; i++)
            {
                string message = Console.ReadLine();
                int sum = message.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                string decrypedMessage = string.Empty;
                foreach (var symbol in message)
                    decrypedMessage += (char)(symbol - sum);
                Match matches = Regex.Match(decrypedMessage, pattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["nameOfPlanet"].Value;
                    int population = int.Parse(matches.Groups["population"].Value);
                    char type = char.Parse(matches.Groups["type"].Value);
                    int soldiersCount = int.Parse(matches.Groups["count"].Value);
                    if (type != 'A')
                        destroyed.Add(name);
                    else
                        attacked.Add(name);
                }
            }
        }

        private static void IO(List<string> attacked, List<string> destroyed)
        {
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
        }
    }
}
