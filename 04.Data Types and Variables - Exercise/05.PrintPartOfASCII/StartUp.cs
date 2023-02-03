namespace _05.PrintPartOfASCII
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int curremtSymbol = start; curremtSymbol <= end; curremtSymbol++)
                Console.Write($"{(char)curremtSymbol} ");
        }
    }
}
