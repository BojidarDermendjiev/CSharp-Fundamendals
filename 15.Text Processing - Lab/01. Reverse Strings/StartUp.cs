namespace _01._Reverse_Strings
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "end")
                Console.WriteLine($"{inputLineFromConsole} = {string.Join("", inputLineFromConsole.Reverse())}");
        }
    }
}
