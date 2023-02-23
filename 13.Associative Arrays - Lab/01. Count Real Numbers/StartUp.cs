namespace _01._Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            SortedDictionary<double, int> conts = Engine();
            IO(conts);
        }

        private static SortedDictionary<double, int> Engine()
        {
            double[] readNumber = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(double.Parse)
                               .ToArray();
            SortedDictionary<double, int> conts = new SortedDictionary<double, int>();
            foreach (var number in readNumber)
            {
                if (conts.ContainsKey(number))
                    conts[number]++;
                else
                    conts.Add(number, 1);
            }

            return conts;
        }

        private static void IO(SortedDictionary<double, int> conts)
        {
            foreach (var number in conts)
                Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }
}
