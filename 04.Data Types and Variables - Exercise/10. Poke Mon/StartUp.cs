namespace _10._Poke_Mon
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokemonCount = default;
            int duplicate = n;
            while (n >= m)
            {
                n -= m;
                pokemonCount++;
                if (n == duplicate / 2 && y > 0)
                    n /= y;
            }
            Console.WriteLine(n);
            Console.WriteLine(pokemonCount);
        }
    }
}
