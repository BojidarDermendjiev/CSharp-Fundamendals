namespace _07._NxN_Matrix
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int printNumber = sizeOfMatrix;
            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                    Console.Write($"{printNumber} ");
                Console.WriteLine();
            }
        }
    }
}
