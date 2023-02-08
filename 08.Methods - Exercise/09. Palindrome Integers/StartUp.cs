namespace _09._Palindrome_Integers
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != "END")
                Console.WriteLine(IsPalidtrome(line));
        }

        private static bool IsPalidtrome(string line)
        {
            for (int currentIndex = 0; currentIndex < line.Length / 2; currentIndex++)
                if (line[currentIndex] != line[line.Length - 1 - currentIndex])
                    return false;
            return true;
        }
    }
}
