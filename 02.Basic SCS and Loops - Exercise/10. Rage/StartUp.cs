namespace _10._Rage
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            int headsetsBroken = lostGames / 2;
            int miceBroken = lostGames / 3;
            int keyboardsBroken = lostGames / 6;
            int displaysBroken = lostGames / 12;
            double headsetsCost = headsetsBroken * double.Parse(Console.ReadLine());
            double miceCost = miceBroken * double.Parse(Console.ReadLine());
            double keyboardsCost = keyboardsBroken * double.Parse(Console.ReadLine());
            double displaysCost = displaysBroken * double.Parse(Console.ReadLine());
            double total = headsetsCost + miceCost + keyboardsCost + displaysCost;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
