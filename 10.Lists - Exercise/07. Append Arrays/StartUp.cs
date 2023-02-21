namespace _07._Append_Arrays
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            string[] arrays = GetInfo();
            List<string> result = new List<string>();
            Engine(arrays, result);
            IO(result);
        }
        private static string[] GetInfo()
        {
            return Console.ReadLine()
                            .Split('|');
        }
        private static void Engine(string[] arrays, List<string> result)
        {
            for (int index = arrays.Length - 1; index >= 0; index--)
            {
                string[] elements = arrays[index].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(elements);
            }
        }
        private static void IO(List<string> result)
        {
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
