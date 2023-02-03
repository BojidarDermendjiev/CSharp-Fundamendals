namespace _06.Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var dataForMonth = new Dictionary<string, string>()
            {
                {"USA", "English" },
                {"England", "English" },
                {"Spain", "Spanish" },
                {"Argentina", "Spanish" },
                {"Mexico", "Spanish" },
            };
            var countryName = Console.ReadLine();
            var language = dataForMonth.FirstOrDefault(x => x.Key == countryName).Value;
            var message = dataForMonth.ContainsKey(countryName) ? $"{language}" : "Error!";
            Console.WriteLine(message);

        }
    }
}
