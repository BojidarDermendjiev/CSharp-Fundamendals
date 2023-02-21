namespace _04._List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var listForManipulation = new List<int>();
            GetInfo(out listForManipulation);
            Engine(listForManipulation);
            IO(listForManipulation);
        }


        private static void GetInfo(out List<int> listForManipulation)
        {
            listForManipulation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        }
        private static void Engine(List<int> listForManipulation)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                switch (inputLine.Split()[0])
                {
                    case "Add":
                        Add(listForManipulation, int.Parse(inputLine.Split()[1]));
                        break;
                    case "Insert":
                        Insert(listForManipulation, int.Parse(inputLine.Split()[1]), int.Parse(inputLine.Split()[2]));
                        break;
                    case "Remove":
                        Remove(listForManipulation, int.Parse(inputLine.Split()[1]));
                        break;
                    case "Shift":
                        if (inputLine.Split()[1] == "left")
                            LeftSwitch(listForManipulation, int.Parse(inputLine.Split()[2]));
                        else
                            RightSwitch(listForManipulation, int.Parse(inputLine.Split()[2]));
                        break;
                }
            }
        }
        private static void Add(List<int> listForManipulation, int number)
        {
            listForManipulation.Add(number);
        }
        private static void Insert(List<int> listForManipulation, int number, int index)
        {
            if (CheckValidator(index, listForManipulation))
                listForManipulation.Insert(index, number);
            else
                Console.WriteLine("Invalid index");
        }
        private static bool CheckValidator(int index, List<int> listForManipulation)
            => index >= 0 && index <= listForManipulation.Count;
        private static void Remove(List<int> listForManipulation, int index)
        {
            if (CheckValidator(index, listForManipulation))
                listForManipulation.RemoveAt(index);
            else
                Console.WriteLine("Invalid index");
        }
        private static void LeftSwitch(List<int> listForManipulation, int times)
        {
            for (int currentOperation = 0; currentOperation < times; currentOperation++)
            {
                var firstElement = listForManipulation.First();
                listForManipulation.Remove(firstElement);
                listForManipulation.Add(firstElement);
            }
        }
        private static void RightSwitch(List<int> listForManipulation, int times)
        {
            for (int currentOperation = 0; currentOperation < times; currentOperation++)
            {
                var lastElement = listForManipulation.Last();
                listForManipulation.Remove(lastElement);
                listForManipulation.Insert(0, lastElement);
            }
        }
        private static void IO(List<int> listForManipulation)
        {
            Console.WriteLine(string.Join(" ", listForManipulation));
        }
    }
}
