namespace _04.Exercise
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes > 59)
            {
                minutes -= 60;
                hour++;
            }
            if (hour > 23)
                hour = 0;
            Console.WriteLine($"{hour}:{minutes}");
        }
    }
}
