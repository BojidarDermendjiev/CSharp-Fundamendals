namespace _05._Remove_Negatives_and_Reverse
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            List<int> inputLine;
            GetInfo(out inputLine);
            Remove(inputLine);
            Reverse(inputLine);
            PrintOutput(inputLine);
        }
        private static void GetInfo(out List<int> inputLine)
        {
            //var list = Console.ReadLine().Split().Select(x => int.Parse(x)).Where(x => x >= 0).Reverse().ToList();
            inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        }
        private static void Remove(List<int> inputLine)
        {
            inputLine.RemoveAll(x => x < 0);
        }
        private static void Reverse(List<int> inputLine)
        {
            inputLine.Reverse();
        }
        private static void PrintOutput(List<int> inputLine)
        {
            Console.WriteLine(inputLine.Count == 0 ? "empty" : string.Join(" ", inputLine));
        }
    }
}
