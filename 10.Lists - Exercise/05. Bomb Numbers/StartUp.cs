namespace _05._Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<int> readNumberFromConsole, bombNumbers;
            GetInfo(out readNumberFromConsole, out bombNumbers);
            Engine(readNumberFromConsole, bombNumbers);
            IO(readNumberFromConsole);
        }


        private static void GetInfo(out List<int> readNumberFromConsole, out List<int> bombNumbers)
        {
            readNumberFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            bombNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        }
        private static void Engine(List<int> readNumberFromConsole, List<int> bombNumbers)
        {
            var specialNumber = bombNumbers[0];
            var powerOfBomb = bombNumbers[1];
            while (true)
            {
                int index = readNumberFromConsole.IndexOf(specialNumber);
                if (index == -1)
                    break;
                int startIndex = index - powerOfBomb;
                if (startIndex < 0)
                    startIndex = 0;
                int count = 2 * powerOfBomb + 1;
                if (count >= readNumberFromConsole.Count - startIndex)
                    count = readNumberFromConsole.Count - startIndex;
                readNumberFromConsole.RemoveRange(startIndex, count);
            }
        }
        private static void IO(List<int> readNumberFromConsole)
        {
            Console.WriteLine(readNumberFromConsole.Sum());
        }
    }
}
