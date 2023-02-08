namespace _05._Add_and_Subtract
{
    using System;
    public class Program
    {
        static void Main()
        {
            int firstNumber, secondNumber, thirdNumber;
            GetInfo(out firstNumber, out secondNumber, out thirdNumber);
            Add(ref firstNumber, secondNumber);
            Subtact(ref firstNumber, thirdNumber);
            PrintResult(firstNumber);
        }
        private static void GetInfo(out int firstNumber, out int secondNumber, out int thirdNumber)
        {
            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());
            thirdNumber = int.Parse(Console.ReadLine());
        }
        private static void Add(ref int firstNumber, int secondNumber)
        {
            firstNumber += secondNumber;
        }
        private static void Subtact(ref int firstNumber, int thirdNumber)
        {
            firstNumber -= thirdNumber;
        }
        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
