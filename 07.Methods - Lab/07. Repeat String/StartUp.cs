namespace _07._Repeat_String
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            string text;
            int count;
            GetInfo(out text, out count);
            PrintRepeatString(text, count);

        }
        private static void GetInfo(out string text, out int count)
        {
            text = Console.ReadLine();
            count = int.Parse(Console.ReadLine());
        }
        private static void PrintRepeatString(string chars, int count)
        {
            var repeatString = new List<string>();
            for (int i = 0; i < count; i++)
                repeatString.Add(chars.ToString());
            Console.WriteLine(string.Join("", repeatString));
        }
    }
}
