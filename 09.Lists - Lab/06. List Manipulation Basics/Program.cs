namespace _06._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            List<int> inputLineFromConsole;
            GetInfo(out inputLineFromConsole);
            Engine(inputLineFromConsole);
            IO(inputLineFromConsole);
        }



        private static void GetInfo(out List<int> input)
        {
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        }
        private static void Engine(List<int> inputLineFromConsole)
        {
            string commands;
            while ((commands = Console.ReadLine().ToLower()) != "end")
            {
                var tokens = commands.Split();
                var firstToken = tokens.First();
                var secondToken = int.Parse(tokens.Skip(1).First());
                switch (firstToken)
                {
                    case "add":
                        Add(inputLineFromConsole, secondToken);
                        break;
                    case "remove":
                        Remove(inputLineFromConsole, secondToken);
                        break;
                    case "removeat":
                        RemoveAt(inputLineFromConsole, secondToken);
                        break;
                    case "insert":
                        var item = int.Parse(tokens.Last());
                        Insert(inputLineFromConsole, secondToken, item);
                        break;
                }
            }
        }
        private static void Add(List<int> inputLineFromConsole, int number)
        {
            inputLineFromConsole.Add(number);
        }
        private static void Remove(List<int> inputLineFromConsole, int number)
        {
            inputLineFromConsole.Remove(number);
        }
        private static void RemoveAt(List<int> inputLineFromConsole, int index)
        {
            if (CorrectlyIndexParams(inputLineFromConsole, index))
                inputLineFromConsole.RemoveAt(index);
        }
        private static void Insert(List<int> inputLineFromConsole, int item, int index)
        {
            if (CorrectlyIndexParams(inputLineFromConsole, index))
                inputLineFromConsole.Insert(index, item);
        }
        private static bool CorrectlyIndexParams(List<int> inputLineFromConsole, int index)
            => index >= 0 && index <= inputLineFromConsole.Count - 1;
        private static void IO(List<int> outputMessage)
        {
            Console.WriteLine(string.Join(" ", outputMessage));
        }
    }
}