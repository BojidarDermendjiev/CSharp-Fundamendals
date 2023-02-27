namespace _05._Nether_Realms
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        static void Main()
        {
            string healthPattern, damegePattern, multiplyDividePattern;
            string[] demones;
            GetInfo(out healthPattern, out damegePattern, out multiplyDividePattern, out demones);
            Engine(healthPattern, damegePattern, multiplyDividePattern, demones);
        }

        private static void GetInfo(out string healthPattern, out string damegePattern, out string multiplyDividePattern, out string[] demones)
        {
            healthPattern = @"[^\+\-\*/\.,0-9]";
            damegePattern = @"-?\d+\.?\d*";
            multiplyDividePattern = @"[\*\/]";
            string splitPattern = @"[,\s]+";
            string input = Console.ReadLine();
            demones = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();
        }

        private static void Engine(string healthPattern, string damegePattern, string multiplyDividePattern, string[] demones)
        {
            for (int curenD = 0; curenD < demones.Length; curenD++)
            {
                string currentDemon = demones[curenD];
                var healthMatched = Regex.Matches(currentDemon, healthPattern);
                var health = 0;
                foreach (Match match in healthMatched)
                {
                    char curChar = char.Parse(match.ToString());
                    health += curChar;
                }
                double damage = 0;
                var demageMatched = Regex.Matches(currentDemon, damegePattern);
                foreach (Match match in demageMatched)
                {
                    double currentDemage = double.Parse(match.ToString());
                    damage += currentDemage;
                }
                var multiplyAndDividers = Regex.Matches(currentDemon, multiplyDividePattern);
                foreach (Match match in multiplyAndDividers)
                {
                    char currentOperator = char.Parse(match.ToString());
                    if (currentOperator == '*')
                        damage *= 2;
                    else
                        damage /= 2;
                }
                IO(currentDemon, health, damage);
            }
        }

        private static void IO(string currentDemon, int health, double damage)
        {
            Console.WriteLine($"{currentDemon} - {health} health, {damage:f2} damage");
        }
    }
}
