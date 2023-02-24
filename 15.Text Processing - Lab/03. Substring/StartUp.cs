namespace _03._Substring
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string wordHaveToBeRemove, inputFromConsole;
            GetInfo(out wordHaveToBeRemove, out inputFromConsole);
            inputFromConsole = Engine(wordHaveToBeRemove, inputFromConsole);
            IO(inputFromConsole);
        }
        private static void GetInfo(out string wordHaveToBeRemove, out string inputFromConsole)
        {
            wordHaveToBeRemove = Console.ReadLine();
            inputFromConsole = Console.ReadLine();
        }
         private static string Engine(string wordHaveToBeRemove, string inputFromConsole)
        {
            while (inputFromConsole.Contains(wordHaveToBeRemove))
            {
                int index = inputFromConsole.IndexOf(wordHaveToBeRemove);
                inputFromConsole = inputFromConsole.Remove(index, wordHaveToBeRemove.Length);
            }

            return inputFromConsole;
        }
        private static void IO(string inputFromConsole)
        {
            Console.WriteLine(inputFromConsole);
        }
    }
}
