using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    public class StartUp
    {
        static void Main()
        {
            List<int> firstListOfNumbers, secondListOfNumbers, mergingList;
            GetInfo(out firstListOfNumbers, out secondListOfNumbers, out mergingList);
            int biggestCount = BiggestLength(firstListOfNumbers, secondListOfNumbers);
            Merging(firstListOfNumbers, secondListOfNumbers, mergingList, biggestCount);
            Console.WriteLine(OutputMessage(mergingList));
        }
        private static void GetInfo(out List<int> firstListOfNumbers, out List<int> secondListOfNumbers, out List<int> mergingList)
        {
            firstListOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            secondListOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            mergingList = new List<int>();
        }
        private static int BiggestLength(List<int> firstListOfNumbers, List<int> secondListOfNumbers)
            => firstListOfNumbers.Count >= secondListOfNumbers.Count ? firstListOfNumbers.Count : secondListOfNumbers.Count;
        private static void Merging(List<int> firstListOfNumbers, List<int> secondListOfNumbers, List<int> mergingList, int biggestCount)
        {
            for (int currentNumberIndex = 0; currentNumberIndex < biggestCount; currentNumberIndex++)
            {
                if (firstListOfNumbers.Count >= secondListOfNumbers.Count)
                {
                    mergingList.Add(firstListOfNumbers[currentNumberIndex]);
                    if (secondListOfNumbers.Count > currentNumberIndex)
                        mergingList.Add(secondListOfNumbers[currentNumberIndex]);
                }
                else
                {
                    if (firstListOfNumbers.Count > currentNumberIndex)
                        mergingList.Add(firstListOfNumbers[currentNumberIndex]);
                    mergingList.Add(secondListOfNumbers[currentNumberIndex]);
                }
            }
        }
        private static string OutputMessage(List<int> mergingList)
            => string.Join(" ", mergingList);
    }
}
