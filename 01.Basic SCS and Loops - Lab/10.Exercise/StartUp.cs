namespace _10.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConosle = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= 10; currentNumber++)
                Console.WriteLine($"{readNumberFromConosle} X {currentNumber} = {readNumberFromConosle * currentNumber}");
        }
    }
}
