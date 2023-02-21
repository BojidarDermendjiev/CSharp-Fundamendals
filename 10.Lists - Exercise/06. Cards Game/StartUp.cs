namespace _06._Cards_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            List<int> firstPlayer, secondPlayer;
            GetInfo(out firstPlayer, out secondPlayer);
            Engine(firstPlayer, secondPlayer);
            IO(firstPlayer, secondPlayer);
        }


        private static void GetInfo(out List<int> firstPlayer, out List<int> secondPlayer)
        {
            firstPlayer = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            secondPlayer = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        }
        private static void Engine(List<int> firstPlayer, List<int> secondPlayer)
        {
            while (firstPlayer.Count != 0  && secondPlayer.Count != 0)
            {
                if (firstPlayer.First() > secondPlayer.First())
                {
                    firstPlayer.Add(firstPlayer.First());
                    firstPlayer.Add(secondPlayer.First());
                }
                else if(firstPlayer.First() < secondPlayer.First()) 
                {
                    secondPlayer.Add(secondPlayer.First());
                    secondPlayer.Add(firstPlayer.First());
                }
                firstPlayer.Remove(firstPlayer.First());
                secondPlayer.Remove(secondPlayer.First());
            }
        }
        private static void IO(List<int> firstPlayer, List<int> secondPlayer)
        {
            Console.WriteLine(firstPlayer.Count == 0 ? $"Second player wins! Sum: {secondPlayer.Sum()}" : $"First player wins! Sum: {firstPlayer.Sum()}");
        }
    }
}
