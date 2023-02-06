namespace _08._Magic_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var readNumbersFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int targetSum = int.Parse(Console.ReadLine());
            for (int currentNumber = 0; currentNumber < readNumbersFromConsole.Length; currentNumber++)
                for (int rightNumber = currentNumber + 1; rightNumber < readNumbersFromConsole.Length; rightNumber++)
                    if (readNumbersFromConsole[currentNumber] + readNumbersFromConsole[rightNumber] == targetSum)
                    {
                        Console.WriteLine($"{readNumbersFromConsole[currentNumber]} {readNumbersFromConsole[rightNumber]}");
                        break;
                    }
        }
    }
}
