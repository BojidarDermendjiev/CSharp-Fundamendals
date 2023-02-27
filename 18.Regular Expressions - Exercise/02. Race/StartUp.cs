namespace _02._Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        static void Main()
        {
            var racer = GetInfo();
            Engine(racer);
            IO(racer);
        }



        private static Dictionary<string, int> GetInfo()
        {
            var racer = new Dictionary<string, int>();
            var nameOfRacers = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var name in nameOfRacers)
                racer.Add(name, 0);
            return racer;
        }
        private static void Engine(Dictionary<string, int> racer)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "end of race")
            {
                int totalDistance = default;
                var patternNameOfRacer = @"[A-Za-z]+";
                var patternDistanceOfRacer = @"\d+";
                var nameMatches = Regex.Matches(inputLineFromConsole, patternNameOfRacer);
                var distanceMatches = Regex.Matches(inputLineFromConsole, patternDistanceOfRacer);
                string currentName = string.Join(string.Empty, nameMatches);
                string currentDigits = string.Join("", distanceMatches);
                for (int i = 0; i < currentDigits.Length; i++)
                    totalDistance += int.Parse(currentDigits[i].ToString());
                if (racer.ContainsKey(currentName))
                    racer[currentName] += totalDistance;
            }
        }
        private static void IO(Dictionary<string, int> racer)
        {
            var place = new string[] { "st", "nd", "rd" };
            int index = default;
            int number = default;
            foreach (var r in racer.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key))
                Console.WriteLine($"{++number}{place[index++]} place: {r}");
        }
    }
}
