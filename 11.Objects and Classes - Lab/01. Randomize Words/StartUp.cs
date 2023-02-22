namespace _01._Randomize_Words
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] inputLineFromConsole;
            GetInfo(out inputLineFromConsole);
            Random rnd = new Random();
            Engine(inputLineFromConsole, rnd);
            IO(inputLineFromConsole);
        }


        private static void GetInfo(out string[] inputLineFromConsole)
        {
            inputLineFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
        private static void Engine(string[] inputLineFromConsole, Random rnd)
        {
            for (int index = 0; index < inputLineFromConsole.Length; index++)
            {
                var possition = rnd.Next(inputLineFromConsole.Length);
                var word = inputLineFromConsole[index];
                (inputLineFromConsole[index], inputLineFromConsole[possition]) = (inputLineFromConsole[possition], word);
            }
        }
        private static void IO(string[] inputLineFromConsole)
        {
            Console.WriteLine(string.Join(Environment.NewLine, inputLineFromConsole));
        }
    }
}
