namespace _08._Math_Power
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double @base, power;
            GetInfo(out @base, out power);
            Console.WriteLine(GetNumberPow(@base, power));
        }
        private static double GetNumberPow(double @base, double power)
            => Math.Pow(@base, power);
        private static void GetInfo(out double @base, out double power)
        {
            @base = double.Parse(Console.ReadLine());
            power = double.Parse(Console.ReadLine());
        }
    }
}
