namespace _03.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            var message = grade >= 3.00 ? "Passed!" : "Failed!";
            Console.WriteLine(message);
        }
    }
}
