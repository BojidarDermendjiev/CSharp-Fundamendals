namespace _01._Valid_Usernames
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var username in text)
                if (IsValid(username))
                    IO(username);
        }


        private static bool IsValid(string username)
        => IsValidLenght(username) && ContainsValidSymbols(username);
        private static bool IsValidLenght(string username)
            => username.Length >= 3 && username.Length <= 16;
        private static bool ContainsValidSymbols(string username)
        {
            foreach (char symbol in username)
                if (!char.IsLetterOrDigit(symbol) && symbol != '_' && symbol != '-')
                    return false;
            return true;
        }
        private static void IO(string username)
        {
            Console.WriteLine(username);
        }

    }
}
