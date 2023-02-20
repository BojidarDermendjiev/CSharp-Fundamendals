namespace _01._Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<double> inputLine = GetInfo();
            SumAdjacentEqualNumbers(inputLine);
            Console.WriteLine(OutputMessage(inputLine));
        }
        private static List<double> GetInfo()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToList();
        }
        private static void SumAdjacentEqualNumbers(List<double> inputLine)
        {
            for (int currentNumberIndex = 0; currentNumberIndex < inputLine.Count; currentNumberIndex++)
            {
                int nextNumber = default;
                if (currentNumberIndex + 1 > inputLine.Count - 1)
                    break;
                else
                    nextNumber = currentNumberIndex + 1;

                if (inputLine[currentNumberIndex] == inputLine[nextNumber])
                {
                    inputLine[currentNumberIndex] += inputLine[nextNumber];
                    inputLine.RemoveAt(nextNumber);
                    currentNumberIndex = -1;
                }
            }
        }
        private static string OutputMessage(List<double> inputLine)
           => string.Join(" ", inputLine);
    }
}
