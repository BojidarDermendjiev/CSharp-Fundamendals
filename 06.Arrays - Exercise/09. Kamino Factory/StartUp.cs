namespace _09._Kamino_Factory
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int sizeOfDNA = int.Parse(Console.ReadLine());
            int[] bestSequance = new int[sizeOfDNA];
            int bestSequanceSize = default;
            int bestSequanceStartedIndex = default;
            int bestSequanceSum = default;
            int sample = default;
            int bestSample = 1;
            string line;
            while ((line = Console.ReadLine()) != "Clone them!")
            {
                sample++;
                var sequance = line.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                int sequanceSum = default;
                foreach (var element in sequance)
                    sequanceSum += element;
                for (int currentElement = 0; currentElement < sequance.Length; currentElement++)
                {
                    if (sequance[currentElement] == 0)
                        continue;
                    var currentSequanceSize = 1;
                    for (int rigthPossition = currentElement + 1; rigthPossition < sequance.Length; rigthPossition++)
                    {
                        if (sequance[currentElement] == sequance[rigthPossition])
                            currentSequanceSize++;
                        else
                            break;
                    }
                    if (currentSequanceSize > bestSequanceSize)
                    {
                        PlacementOfElements(out bestSequance, out bestSequanceSize, out bestSequanceStartedIndex, out bestSequanceSum, sample, out bestSample, sequance, sequanceSum, currentElement, currentSequanceSize);
                    }
                    else if (currentSequanceSize == bestSequanceSize)
                    {
                        if (currentElement < bestSequanceStartedIndex)
                        {
                            PlacementOfElements(out bestSequance, out bestSequanceSize, out bestSequanceStartedIndex, out bestSequanceSum, sample, out bestSample, sequance, sequanceSum, currentElement, currentSequanceSize);
                        }
                        else if (currentElement == bestSequanceStartedIndex && sequanceSum > bestSequanceSum)
                        {
                            PlacementOfElements(out bestSequance, out bestSequanceSize, out bestSequanceStartedIndex, out bestSequanceSum, sample, out bestSample, sequance, sequanceSum, currentElement, currentSequanceSize);
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequanceSum}.");
            Console.WriteLine(string.Join(" ", bestSequance));
        }

        private static void PlacementOfElements(out int[] bestSequance, out int bestSequanceSize, out int bestSequanceStartedIndex, out int bestSequanceSum, int sample, out int bestSample, int[] sequance, int sequanceSum, int currentElement, int currentSequanceSize)
        {
            bestSequanceSize = currentSequanceSize;
            bestSequanceStartedIndex = currentElement;
            bestSequanceSum = sequanceSum;
            bestSequance = sequance;
            bestSample = sample;
        }
    }
}
