namespace _04._Text_Filter
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] removeWords;
            string text;
            GetInfo(out removeWords, out text);
            text = Engine(removeWords, text);
            IO(text);
        }
        private static void GetInfo(out string[] removeWords, out string text)
        {
            removeWords = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            text = Console.ReadLine();
        }
        private static string Engine(string[] removeWords, string text)
        {
            foreach (var word in removeWords)
                text = text.Replace(word, new string('*', word.Length));
            return text;
        }
        private static void IO(string text)
        {
            Console.WriteLine(text);
        }
    }
}
