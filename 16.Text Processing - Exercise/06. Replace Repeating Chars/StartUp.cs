namespace _06._Replace_Repeating_Chars
{
    using System;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            ConvertText(text, result);
            IO(result);
        }
        private static void ConvertText(string text, StringBuilder result)
        {
            char prevSymbol = '\0';
            foreach (var letter in text)
            {
                if (letter != prevSymbol)
                    result.Append(letter);
                prevSymbol = letter;
            }
        }
        private static void IO(StringBuilder output)
        {
            Console.WriteLine(output.ToString());
        }
    }
}
