namespace _01._Day_of_Week
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var daysOfWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            Console.WriteLine(readNumberFromConsole <= 0 || readNumberFromConsole > 7 ? "Invalid day!" : daysOfWeek[readNumberFromConsole - 1]);
        }
    }
}
