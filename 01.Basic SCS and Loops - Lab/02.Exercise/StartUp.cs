namespace _02.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            var message = grade >= 3.00 ? $"Passed!" : String.Empty;
            Console.WriteLine(message);
        }
    }
}
