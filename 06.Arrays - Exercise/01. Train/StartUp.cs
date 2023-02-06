namespace _01._Train
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] currentPeopleInWagon = new int[numberOfWagons];
            int total = default;
            for (int currentWagon = 0; currentWagon < numberOfWagons; currentWagon++)
            {
                currentPeopleInWagon[currentWagon] = int.Parse(Console.ReadLine());
                total += currentPeopleInWagon[currentWagon];
            }
            Console.WriteLine(string.Join(" ", currentPeopleInWagon));
            Console.WriteLine(total);
        }
    }
}
