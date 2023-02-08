namespace _01._Smallest_of_Three_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[] readNumbersFromConsole = GetInfo();
            Console.WriteLine(readNumbersFromConsole.Min());
        }

        private static int[] GetInfo()
        => new int[]
                {
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine())
                };
    }
}
