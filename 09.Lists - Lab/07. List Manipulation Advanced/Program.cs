namespace _07._List_Manipulation_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            bool isListChange = false;
            List<int> inputLineFromConsole;
            GetInfo(out inputLineFromConsole);
            Engine(inputLineFromConsole, ref isListChange);
            if (isListChange)
                IO(inputLineFromConsole);
        }



        private static void GetInfo(out List<int> input)
        {
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        }
        private static void Engine(List<int> inputLineFromConsole, ref bool isItChange)
        {
            string commands;
            while ((commands = Console.ReadLine().ToLower()) != "end")
            {
                var tokens = commands.Split();
                var firstToken = tokens.First();
                switch (firstToken)
                {
                    case "add":
                        isItChange = true;
                        var addingNumber = int.Parse(tokens.Last());
                        Add(inputLineFromConsole, addingNumber);
                        break;
                    case "remove":
                        isItChange = true;
                        var removingNumber = int.Parse(tokens.Last());
                        Remove(inputLineFromConsole, removingNumber);
                        break;
                    case "removeat":
                        isItChange = true;
                        var index = int.Parse(tokens.Last());
                        RemoveAt(inputLineFromConsole, index);
                        break;
                    case "insert":
                        isItChange = true;
                        var _index = int.Parse(tokens.Skip(1).First());
                        var item = int.Parse(tokens.Last());
                        Insert(inputLineFromConsole, _index, item);
                        break;

                    case "contains":
                        var searchingNumber = int.Parse(tokens.Skip(1).First());
                        Contains(inputLineFromConsole, searchingNumber);
                        break;
                    case "printeven":
                        PrintEven(inputLineFromConsole);
                        break;
                    case "printodd":
                        PrintOdd(inputLineFromConsole);
                        break;
                    case "getsum":
                        GetSum(inputLineFromConsole);
                        break;
                    case "filter":
                        var condition = tokens.Skip(1).First();
                        var limit = int.Parse(tokens.Last());
                        Filter(inputLineFromConsole, condition, limit);
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
        private static void Contains(List<int> inputLineFromConsole, int searchingNumber)
        {
            Console.WriteLine(inputLineFromConsole.Contains(searchingNumber) ? "Yes" : "No such number");
        }
        private static void PrintEven(List<int> inputLineFromConsole)
        {
            Console.WriteLine((string.Join(" ", inputLineFromConsole.Where(x => x % 2 == 0))));
        }
        private static void PrintOdd(List<int> inputLineFromConsole)
        {
            Console.WriteLine((string.Join(" ", inputLineFromConsole.Where(x => x % 2 != 0))));
        }
        private static void GetSum(List<int> inputLineFromConsole)
        {
            Console.WriteLine(inputLineFromConsole.Sum());
        }
        private static void Filter(List<int> inputLineFromConsole, string condition, int limit)
        {
            if (condition == ">")
                Console.WriteLine(string.Join(" ", inputLineFromConsole.Where(x => x > limit)));
            else if (condition == "<")
                Console.WriteLine(string.Join(" ", inputLineFromConsole.Where(x => x < limit)));
            else if (condition == ">=")
                Console.WriteLine(string.Join(" ", inputLineFromConsole.Where(x => x >= limit)));
            else if (condition == "<=")
                Console.WriteLine(string.Join(" ", inputLineFromConsole.Where(x => x <= limit)));
        }
        private static void IO(List<int> outputMessage)
        {
            Console.WriteLine(string.Join(" ", outputMessage));
        }
    }
}