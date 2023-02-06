namespace _07._Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var sequanceOfElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int bestSequanceSize = default;
            int bestSequanceNumber = default;
            for (int currentElement = 0; currentElement < sequanceOfElements.Length; currentElement++)
            {
                int sequanceSize = 1;
                for (int currentIndex = currentElement + 1; currentIndex < sequanceOfElements.Length; currentIndex++)
                {
                    if (sequanceOfElements[currentElement] == sequanceOfElements[currentIndex])
                        sequanceSize++;
                    else
                        break;
                }
                if (sequanceSize > bestSequanceSize)
                {
                    bestSequanceSize = sequanceSize;
                    bestSequanceNumber = sequanceOfElements[currentElement];
                }
            }
            for (int i = 0; i < bestSequanceSize; i++)
                Console.Write(bestSequanceNumber + " ");
        }
    }
}
