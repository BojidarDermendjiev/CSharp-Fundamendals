namespace _07._String_Explosion
{
    using System;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            Exposion(text, result);
            IO(result);
        }
        private static void Exposion(string text, StringBuilder result)
        {
            int boom = default;
            for (int currentIndex = 0; currentIndex < text.Length; currentIndex++)
            {
                char symbol = text[currentIndex];
                if (symbol == '>')
                {
                    boom += text[currentIndex + 1] - '0';
                    result.Append(symbol);
                }
                else if (boom > 0)
                    boom -= 1;
                else
                    result.Append(symbol);
            }
        }
        private static void IO(StringBuilder output)
        {
            Console.WriteLine(output.ToString());
        }
    }
}
