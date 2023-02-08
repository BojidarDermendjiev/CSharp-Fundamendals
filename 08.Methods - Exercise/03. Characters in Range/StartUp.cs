namespace _03._Characters_in_Range
{
    using System;
    public class Program
    {
        static void Main()
        {
            char start, end;
            GetInfo(out start, out end);
            PrintASCIITableBetweenStartToEnd(start, end);
        }


        private static void GetInfo(out char start, out char end)
        {
            start = char.Parse(Console.ReadLine());
            end = char.Parse(Console.ReadLine());
        }
        private static void PrintASCIITableBetweenStartToEnd(char start, char end)
        {
            if (start < end)
                for (int i = start + 1; i < end; i++)
                    ConsoleWrite(i);
            else
                for (int i = end + 1; i < start; i++)
                    Console.Write($"{(char)i} ");
        }

        private static void ConsoleWrite(int i)
        {
            Console.Write($"{(char)i} ");
        }
    }
}
