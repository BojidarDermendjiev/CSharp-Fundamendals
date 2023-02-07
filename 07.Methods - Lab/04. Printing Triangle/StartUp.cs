namespace _04._Printing_Triangle
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int demension = int.Parse(Console.ReadLine());
            for (int row = 1; row <= demension; row++)
                Outputter(row);
            for (int row = demension - 1; row >= 1; row--)
                Outputter(row);
        }

        private static void Outputter(int row)
        {
            for (int col = 1; col <= row; col++)
                Console.Write($"{col} ");
            Console.WriteLine();
        }
    }
}
