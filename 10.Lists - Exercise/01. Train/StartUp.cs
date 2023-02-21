namespace _01._Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var listOfWagons = new List<int>();
            int maxCapacityForCurrentWagon = default(int);
            GetInfo(out listOfWagons, out maxCapacityForCurrentWagon);
            Engine(listOfWagons, maxCapacityForCurrentWagon);
            IO(listOfWagons);
        }


        private static void GetInfo(out List<int> listOfWagons, out int capacity)
        {
            listOfWagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            capacity = int.Parse(Console.ReadLine());
        }
        private static void Engine(List<int> listOfWagons, int maxCapacityForCurrentWagon)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()).ToLower() != "end")
            {
                var tokens = inputLineFromConsole.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Add")
                    Add(listOfWagons, int.Parse(tokens[1]));
                else
                    FindSpaceForPassangersInWagons(listOfWagons, maxCapacityForCurrentWagon, int.Parse(tokens[0]));
            }
        }


        private static void Add(List<int> listOfWagons, int passengers)
        {
            listOfWagons.Add(passengers);
        }
        private static void FindSpaceForPassangersInWagons(List<int> listOfWagons, int maxCapacityForCurrentWagon, int incomePassangers)
        {
            for (int currentWagon = 0; currentWagon < listOfWagons.Count; currentWagon++)
                if (listOfWagons[currentWagon] + incomePassangers <= maxCapacityForCurrentWagon)
                {
                    listOfWagons[currentWagon] += incomePassangers;
                    break;
                }
        }
        private static void IO(List<int> listOfWagons)
        {
            Console.WriteLine(string.Join(" ", listOfWagons));
        }
    }
}
