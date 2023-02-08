namespace _06._Middle_Characters
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string inputLine;
            GetInfo(out inputLine);
            string middileCharacter;
            FindMiddleCharachter(out middileCharacter, inputLine);
            PrintMessage(middileCharacter);
        }


        private static void GetInfo(out string inputLine)
        {
            inputLine = Console.ReadLine();
        }
        private static string FindMiddleCharachter(out string middileCharacter, string inputLine)
        {
            if (inputLine.Length % 2 != 0)
                return middileCharacter = $"{inputLine[(inputLine.Length - 1) / 2]}";
            else
                return middileCharacter = $"{inputLine[(inputLine.Length / 2) - 1]}{inputLine[inputLine.Length / 2]}";
        }
        private static void PrintMessage(string middileCharacter)
        {
            Console.WriteLine(middileCharacter);
        }
    }
}
