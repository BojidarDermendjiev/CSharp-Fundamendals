namespace _01._Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        static void Main()
        {
            string text = GetInfo();
            var patten = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");
            MatchCollection matches = patten.Matches(text);
            IO(matches);
        }
        private static string GetInfo()
              => Console.ReadLine();

        private static void IO(MatchCollection mathe)
        {
            foreach (Match item in mathe)
                Console.Write("{0} ", string.Join(" ", item));
        }
    }
}
