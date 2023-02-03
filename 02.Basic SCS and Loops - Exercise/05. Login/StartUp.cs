namespace _05._Login
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string inputLine;
            inputLine = Console.ReadLine();
            inputLine = StringReverse(inputLine);
            string loggingInput;
            int counter = default;
            while ((loggingInput = Console.ReadLine()) != inputLine)
            {
                if (counter >= 3)
                    break;
                counter++;
                Console.WriteLine("Incorrect password. Try again.");
            }
            if (loggingInput == inputLine)
                Console.WriteLine($"User {inputLine} logged in.");
            else
                Console.WriteLine($"User {inputLine} blocked!");
        }
        public static string StringReverse(string text)
        {
            if (text.Length > 0)
                return text[text.Length - 1] + StringReverse(text.Substring(0, text.Length - 1));
            else
                return text;
        }
    }
}
