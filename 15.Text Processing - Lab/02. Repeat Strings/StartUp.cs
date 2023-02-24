namespace _02._Repeat_Strings
{
    using System;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            string[] inputLineFromConsole = GetInfo();
            StringBuilder sb = new StringBuilder();
            Engine(inputLineFromConsole, sb);
            IO(sb);
        }
        private static string[] GetInfo()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
        private static void Engine(string[] inputLineFromConsole, StringBuilder sb)
        {
            foreach (var symbol in inputLineFromConsole)
                for (int currentIndex = 0; currentIndex < symbol.Length; currentIndex++)
                    sb.Append(symbol);
        }
        private static void IO(StringBuilder sb)
        {
            Console.WriteLine(sb);
        }
    }
}
