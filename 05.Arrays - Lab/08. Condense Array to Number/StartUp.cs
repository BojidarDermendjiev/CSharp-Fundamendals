namespace _08._Condense_Array_to_Number
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var readNumbersFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var condensed = new int[readNumbersFromConsole.Length - 1];
            for (int currentIndex = readNumbersFromConsole.Length - 1; currentIndex >= 1; currentIndex--)
            {
                for (int possition = 0; possition < currentIndex; possition++)
                    condensed[possition] = readNumbersFromConsole[possition] + readNumbersFromConsole[possition + 1];
                readNumbersFromConsole = condensed;
            }
            Console.WriteLine(readNumbersFromConsole.First());
            Array.Clear(condensed, 0, condensed.Length);
            Array.Clear(readNumbersFromConsole, 0, readNumbersFromConsole.Length);
        }
    }
}
