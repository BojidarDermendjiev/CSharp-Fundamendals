namespace _05._Digits__Letters_and_Other
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var  inputLineFromConsole = Console.ReadLine();
            IO(inputLineFromConsole);
        }

        private static void IO(string output)
        {
            Console.WriteLine(output.Where(x => char.IsDigit(x)).ToArray());
            Console.WriteLine(output.Where(x => char.IsLetter(x)).ToArray());
            Console.WriteLine(output.Where(x => char.IsSymbol(x)).ToArray());
        }
    }
}
