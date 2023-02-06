namespace _05._Top_Integers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var readInputFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            for (int currentNumber = 0; currentNumber < readInputFromConsole.Length; currentNumber++)
            {
                bool isBiggerNumber = true;
                for (int index = currentNumber + 1; index < readInputFromConsole.Length; index++)
                    if (readInputFromConsole[currentNumber] <= readInputFromConsole[index])//left and right number
                    {
                        isBiggerNumber = false;
                        break;
                    }
                if (isBiggerNumber)
                    Console.Write(readInputFromConsole[currentNumber] + " ");
            }
        }
    }
}
