namespace _07._Equal_Arrays
{
    using System;
    using System.Linq;

    public class STartUp
    {
        static void Main()
        {
            var firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int total = default;
            for (int currentIndex = 0; currentIndex < firstArray.Length; currentIndex++)
            {
                if (firstArray[currentIndex] != secondArray[currentIndex])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {currentIndex} index");
                    return;
                }
                total += firstArray[currentIndex];
            }
            Console.WriteLine($"Arrays are identical. Sum: {total}");
        }
    }
}
