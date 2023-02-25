namespace _02._Match_Phone_Number
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class StartUp
    {
        static void Main()
        {
            string phone = GetInfo();
            string[] matchesPhones = Engine(phone);
            IO(matchesPhones);
        }
        private static string GetInfo()
            => Console.ReadLine();

        private static string[] Engine(string phone)
        {
            string regex = @"$(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            MatchCollection phoneMatches = Regex.Matches(phone, regex);
            string[] matchesPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            return matchesPhones;
        }

        private static void IO(string[] matchesPhones)
        {
            Console.WriteLine(string.Join(", ", matchesPhones));
        }
    }
}
