namespace _07._Concat_Names
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            //Again tricky one :) 
            //string firstName = Console.ReadLine();
            //string secondName = Console.ReadLine();
            //string input = Console.ReadLine();
            //Console.WriteLine($"{firstName}{input}{secondName}");
            var inputLine = new string[3];
            inputLine[0] = ReadLine();
            inputLine[2] = ReadLine();
            inputLine[1] = ReadLine();
            Console.WriteLine(String.Join(String.Empty, inputLine));
        }

        private static string ReadLine() => Console.ReadLine();
    }
}
