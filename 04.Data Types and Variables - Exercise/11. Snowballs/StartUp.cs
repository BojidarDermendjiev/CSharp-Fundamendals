namespace _11._Snowballs
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        static void Main()
        {
            int numberOFSnowballs = int.Parse(Console.ReadLine());
            BigInteger maxSnowballValue = default;
            string printMessage = string.Empty;
            for (int currentSnowball = 1; currentSnowball <= numberOFSnowballs; currentSnowball++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    printMessage = ($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
                }
            }
            Console.WriteLine(printMessage);
        }
    }
}
