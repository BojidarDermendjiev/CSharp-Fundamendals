namespace _03._Elevator
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int countOfPeopleUsedElevator = int.Parse(Console.ReadLine());
            int capacityOfTheElevator = int.Parse(Console.ReadLine());
            double courses = (int)Math.Ceiling((double)countOfPeopleUsedElevator / capacityOfTheElevator);
            Console.WriteLine(courses);
        }
    }
}
