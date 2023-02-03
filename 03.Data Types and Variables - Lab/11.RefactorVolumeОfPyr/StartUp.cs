namespace _11.RefactorVolumeОfPyr
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double length, width, height = default;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            double volume = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
