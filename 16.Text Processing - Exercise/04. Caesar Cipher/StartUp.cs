namespace _04._Caesar_Cipher
{
    using System;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            string text = GetInfo();
            StringBuilder encyptedText = new StringBuilder();
            Engine(text, encyptedText);
            IO(encyptedText);
        }
        private static void Engine(string text, StringBuilder encyptedText)
        {
            foreach (char letter in text)
                encyptedText.Append((char)(letter + 3));
        }
        private static string GetInfo()
            => Console.ReadLine();
        private static void IO(StringBuilder encyptedText)
        {
            Console.WriteLine(encyptedText);
        }
    }
}
