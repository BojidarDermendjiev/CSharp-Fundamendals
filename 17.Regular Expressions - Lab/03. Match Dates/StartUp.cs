namespace _03._Match_Dates
{
    using System;
    using System.Text.RegularExpressions;
    public class StartUp
    {
        static void Main()
        {
            string datesStrings = GetInfo();
            MatchCollection dates = Engine(datesStrings);
            IO(dates);
        }
        private static string GetInfo()
            => Console.ReadLine();
        private static MatchCollection Engine(string datesStrings)
        {
            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var dates = Regex.Matches(datesStrings, regex);
            return dates;
        }
        private static void IO(MatchCollection dates)
        {
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
