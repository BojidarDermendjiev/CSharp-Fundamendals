namespace _02._Character_Multiplier
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int result = MultiplyWords(words[0], words[1]);
            IO(result);
        }
        private static int MultiplyWords(string first, string second)
        {
            int minLenght = Math.Min(first.Length, second.Length);
            int sum = default;
            for (int index = 0; index < minLenght; index++)
                sum += first[index] * second[index];
            if (first.Length > second.Length)
               return sum += SumReminingChars(first, minLenght);
            else
               return sum += SumReminingChars(second, minLenght);
        }
        private static int SumReminingChars(string word, int index)
        {
            int sum = default;
            for (int currentIndex = index; currentIndex < word.Length; currentIndex++)
                sum += word[currentIndex];
            return sum;
        }
        private static void IO(int result)
        {
            Console.WriteLine(result);
        }
    }
}
