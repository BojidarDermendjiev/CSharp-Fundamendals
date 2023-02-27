namespace _06._Extract_Emails
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        static void Main()
        {
            string pattern, input;
            GetInfo(out pattern, out input);
            MatchCollection matches = Engine(pattern, input);
            IO(matches);
        }
        private static void GetInfo(out string pattern, out string input)
        {
            pattern = @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b";
            input = Console.ReadLine();
        }
        private static MatchCollection Engine(string pattern, string input)
             => Regex.Matches(input, pattern);
        private static void IO(MatchCollection matches)
        {
            matches.ToList().ForEach(Console.WriteLine);
        }
    }
}
