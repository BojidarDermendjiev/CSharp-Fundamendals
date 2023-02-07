namespace _06._Calculate_Rectangle_Area
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double width, height;
            GetInfo(out width, out height);
            Console.WriteLine(GetRectangleArea(width, height));
        }
        private static double GetRectangleArea(double width, double height)
            => width * height;
        private static void GetInfo(out double width, out double height)
        {
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
        }
    }
}
