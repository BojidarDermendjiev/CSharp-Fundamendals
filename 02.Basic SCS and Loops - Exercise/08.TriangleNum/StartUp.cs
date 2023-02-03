namespace _08.TriangleNum
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            for (int row = 1; row <= readNumberFromConsole; row++)
            {
                for (int col = 1; col <= row; col++)
                    Console.Write(row + " ");
                Console.WriteLine();
            }
        }
    }
}
