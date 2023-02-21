namespace _03._House_Party
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, string> housePartyData = new Dictionary<string, string>();
            Engine(housePartyData, numberOfLines);
            IO(housePartyData);
        }
        private static void Engine(Dictionary<string, string> housePartyData, int numberOfLines)
        {
            for (int currentLine = 1; currentLine <= numberOfLines; currentLine++)
            {
                var inputLine = Console.ReadLine();
                var length = inputLine.Split().Length;
                var nameOfGuest = inputLine.Split()[0];
                if (length == 3)
                {
                    if (!housePartyData.ContainsKey(nameOfGuest))
                        housePartyData.Add(nameOfGuest, inputLine);
                    else
                        Console.WriteLine(NameIsAlreadyInList(nameOfGuest));
                }
                else if (length == 4)
                {
                    if (!housePartyData.ContainsKey(nameOfGuest))
                        Console.WriteLine(NameCannotBeFound(nameOfGuest));
                    else
                        housePartyData.Remove(nameOfGuest);
                }
            }
        }
        private static string NameIsAlreadyInList(string nameOfGuest)
            => $"{nameOfGuest} is already in the list!";
        private static string NameCannotBeFound(string nameOfGuest)
            => $"{nameOfGuest} is not in the list!";
        private static void IO(Dictionary<string, string> housePartyData)
        {
            foreach (var namesOfGuest in housePartyData.Keys)
                Console.WriteLine(namesOfGuest);
        }
    }
}
