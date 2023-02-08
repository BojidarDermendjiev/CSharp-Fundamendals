namespace _02._Vowels_Count
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Action<int> print = output => Console.WriteLine(output);
            string inputLine;
            int count = default;
            GetInfo(out inputLine);
            foreach (var letter in inputLine)
                GetCountOfVowels(letter, ref count);
            print(count);
        }


        private static string GetInfo(out string inputLine)
            => inputLine = Console.ReadLine();
        private static void GetCountOfVowels(char letter, ref int count)
        {
            if (letter == 'a' || letter == 'u' || letter == 'o' || letter == 'e' || letter == 'i')
                count++;
        }

    }
}
