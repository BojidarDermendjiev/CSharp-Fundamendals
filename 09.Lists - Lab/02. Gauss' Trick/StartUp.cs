namespace _02._Gauss__Trick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            List<int> inputLine;
            GetInfo(out inputLine);
            int count = inputLine.Count;
            SumAllNumber(inputLine, count);
            Console.WriteLine(PrintResult(inputLine));
        }
        private static void GetInfo(out List<int> inputLine)
        {
            inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        }
        private static void SumAllNumber(List<int> inputLine, int count)
        {
            for (int currentNumberIndex = 0; currentNumberIndex < count / 2; currentNumberIndex++)
            { 
                inputLine[currentNumberIndex] += inputLine[inputLine.Count - 1];
                inputLine.RemoveAt(inputLine.Count - 1);
            }
        }
        private static string PrintResult(List<int> message)
            => string.Join(" ", message);
    }
}
