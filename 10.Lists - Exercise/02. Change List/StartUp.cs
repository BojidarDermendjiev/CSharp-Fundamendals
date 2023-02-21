namespace _02._Change_List
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
            while ((inputLine = Console.ReadLine()).ToLower() != "end")
            {
                switch (inputLine.Split()[0].ToLower())
                {
                    case "delete":
                        Delete(listForManipulation, int.Parse(inputLine.Split()[1]));
                        break;
                    case "insert":
                        Insert(listForManipulation, int.Parse(inputLine.Split()[1]), int.Parse(inputLine.Split()[2]));
                        break;
                }
            }
        }

        private static void Delete(List<int> listForManipulation, int numberForRemove)
        {
            listForManipulation.RemoveAll(x => x == numberForRemove);
        }

        private static void Insert(List<int> listForManipulation, int element, int index)
        {
            if (CheckForCorrectlyIndex(index, listForManipulation))
                listForManipulation.Insert(index, element);
        }

        private static bool CheckForCorrectlyIndex(int index, List<int> listForManipulation)
            => index >= 0 && index <= listForManipulation.Count;
        private static void IO(List<int> finalResult)
        {
            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
