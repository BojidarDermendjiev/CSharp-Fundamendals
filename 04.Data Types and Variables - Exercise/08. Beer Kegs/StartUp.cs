namespace _08._Beer_Kegs
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string bestModel = string.Empty;
            double bestVolume = double.MinValue;
            for (int currentKeg = 1; currentKeg <= numberOfKegs; currentKeg++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigth = int.Parse((Console.ReadLine()));
                double volume = Math.PI * Math.Pow(radius, 2) * heigth;
                if (volume > bestVolume)
                { 
                    bestVolume = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}
