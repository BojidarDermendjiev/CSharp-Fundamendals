namespace _01.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var studenName = Console.ReadLine();
            var studentAge = int.Parse(Console.ReadLine());
            var averageGarde = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studenName}, Age: {studentAge},Grade: {averageGarde}");
        }
    }
}
